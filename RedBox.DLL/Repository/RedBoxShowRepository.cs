using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBox.IDAL;
using RedBox.Models.RedBox;

namespace RedBox.DLL
{
    public class RedBoxShowRepository:BaseRepository<vb_redbox_shows>,IRedBoxShowRepository 
    {
        public dynamic GetRedBoxShow(string  code)
        {
            var redboxshow = from redboxShows in nContext.vb_redbox_shows
                             join box in nContext.redbox 
                             on redboxShows.redbox_id equals box.id
                             where box.code == code
                             select new {redboxShows.show_qrcode , redboxShows.shows_screen_adv,redboxShows.third_screen ,box.code };
            return redboxshow;
        }
    }
}
