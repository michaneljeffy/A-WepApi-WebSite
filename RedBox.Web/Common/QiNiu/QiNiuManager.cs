using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Qiniu.Util;
using Qiniu.Storage;
using Qiniu.Http;

namespace RedBox.Web.Common
{
   
    /// <summary>
    /// qiniu 公共管理类
    /// </summary>
    public class QiNiuManager
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public QiNiuManager()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        public static readonly string AK = "";

        /// <summary>
        /// 
        /// </summary>
        public static  readonly string SK = "";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static void UploadFile()
        {
            Mac mac = new Mac(AK,SK);
            Auth auth = new Auth(mac);
           
            string bucket = "";
            string saveKey = "";
            string localFile = "";

            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = bucket;
            putPolicy.SaveKey = saveKey;

            putPolicy.SetExpires(2600);
            putPolicy.DeleteAfterDays = 1;

            string policy = putPolicy.ToJsonString();
            string token = Auth.CreateUploadToken(mac,policy);
            Config qconfig = new Config() { Zone=Zone.ZONE_CN_East,UseHttps = true};
            UploadManager umanager = new UploadManager(qconfig);
            UploadProgressHandler uploadProgressChanged = new UploadProgressHandler(OnUploadProgressChanged);
            PutExtra extra = new PutExtra() {MaxRetryTimes = 3,ProgressHandler = uploadProgressChanged  };    
            HttpResult result= umanager.UploadFile(localFile,saveKey ,token,extra);
        }

        private static void OnUploadProgressChanged(long uploadedBytes,long totalBytes)
        {
            if(uploadedBytes == totalBytes)
            {
                Console.WriteLine("上传成功");
            }
            else
            {
                Console.WriteLine("上传中");
            }
        }

        /// <summary>
        /// 分片上传
        /// </summary>
        public static void ResumableUplaodFile()
        {
            Mac mac = new Mac(AK, SK);
            Auth auth = new Auth(mac);
            string bucket = "";
            string saveKey = "";
            string localFile = "";
           // string recordPath = ""; //上传进度保存的目录
            string recordFile = ""; //上传进度保存为文件

            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = bucket;
            putPolicy.SaveKey = saveKey;
            putPolicy.PersistentOps = "PERSISTENT_OPS";
            putPolicy.SetExpires(3600);
            putPolicy.DeleteAfterDays = 1;

            string policy = putPolicy.ToJsonString();
            string token = Auth.CreateUploadToken(mac, policy);
            Config qconfig = new Config() { Zone = Zone.ZONE_CN_East, UseHttps = true, UseCdnDomains = false,ChunkSize = ChunkUnit.U1024K };

            ResumableUploader ruplaod = new ResumableUploader(qconfig);

            UploadProgressHandler uploadProgressChanged = new UploadProgressHandler(ResumableUploader.DefaultUploadProgressHandler);
            UploadController upctl = new UploadController(uploadControl);
            PutExtra extra = new PutExtra() { MaxRetryTimes = 3 , ResumeRecordFile = recordFile, UploadController = upctl};
            HttpResult result = ruplaod.UploadFile(localFile, saveKey, token, extra);
        }

        private static bool paused = false;//内部变量
        private static UploadControllerAction uploadControl()
        {
            paused = !paused;
            if (paused )
            {
                return UploadControllerAction.Suspended;
            }
            else
            {
                return UploadControllerAction.Suspended;
            }
        }

        /// <summary>
        /// 下载共有文件
        /// </summary>
        public static void DownloadPublicFile()
        {
            string rawUrl = "";
            string savedFile = "";
            HttpResult result = DownloadManager.Download(rawUrl ,savedFile);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 下载私有文件
        /// </summary>
        public static void DownloadPrivateFile()
        {
            string AK = "";
            string SK = "";
            Mac mac = new Mac(AK,SK);
            string rawUrl = "";
            string savedFile = "";

            string accUrl = DownloadManager.CreatePrivateUrl(mac, rawUrl, "filename");

            HttpResult result = DownloadManager.Download(accUrl , savedFile);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GetBucketInfo()
        {
            Mac mac = new Mac("", "");
            Config qconfig = new Config() { Zone = Zone.ZONE_CN_East, UseHttps = true, UseCdnDomains = false, ChunkSize = ChunkUnit.U1024K };
            BucketManager bm = new BucketManager(mac,qconfig);
            bm.Stat("bucket", "key");
        }
    }
}