namespace RedBox.Models.RedBox
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RedBoxModel : DbContext
    {
        public RedBoxModel()
            : base("name=RedBox")
        {
        }

        public virtual DbSet<activity> activity { get; set; }
        public virtual DbSet<activity_privilege> activity_privilege { get; set; }
        public virtual DbSet<address> address { get; set; }
        public virtual DbSet<advertise> advertise { get; set; }
        public virtual DbSet<advertise_adv> advertise_adv { get; set; }
        public virtual DbSet<advertise_redbox> advertise_redbox { get; set; }
        public virtual DbSet<agent_daily> agent_daily { get; set; }
        public virtual DbSet<agent_daily_detail> agent_daily_detail { get; set; }
        public virtual DbSet<area> area { get; set; }
        public virtual DbSet<article_coupon> article_coupon { get; set; }
        public virtual DbSet<article_official> article_official { get; set; }
        public virtual DbSet<article_print> article_print { get; set; }
        public virtual DbSet<article_print_statistic> article_print_statistic { get; set; }
        public virtual DbSet<article_record> article_record { get; set; }
        public virtual DbSet<audit> audit { get; set; }
        public virtual DbSet<audit_facade> audit_facade { get; set; }
        public virtual DbSet<balance> balance { get; set; }
        public virtual DbSet<bill> bill { get; set; }
        public virtual DbSet<channel> channel { get; set; }
        public virtual DbSet<channel_account_number_seed> channel_account_number_seed { get; set; }
        public virtual DbSet<channel_business_info> channel_business_info { get; set; }
        public virtual DbSet<channel_feedback> channel_feedback { get; set; }
        public virtual DbSet<channel_machine> channel_machine { get; set; }
        public virtual DbSet<conf_bh_sn> conf_bh_sn { get; set; }
        public virtual DbSet<coupon> coupon { get; set; }
        public virtual DbSet<data_agent> data_agent { get; set; }
        public virtual DbSet<data_agent_old> data_agent_old { get; set; }
        public virtual DbSet<data_agent_old_copy> data_agent_old_copy { get; set; }
        public virtual DbSet<data_agent_pay> data_agent_pay { get; set; }
        public virtual DbSet<data_agent_promo> data_agent_promo { get; set; }
        public virtual DbSet<data_coinprint> data_coinprint { get; set; }
        public virtual DbSet<data_gucci> data_gucci { get; set; }
        public virtual DbSet<data_laneige> data_laneige { get; set; }
        public virtual DbSet<data_laneige_statistic> data_laneige_statistic { get; set; }
        public virtual DbSet<data_official> data_official { get; set; }
        public virtual DbSet<data_official_account> data_official_account { get; set; }
        public virtual DbSet<data_official_copy> data_official_copy { get; set; }
        public virtual DbSet<data_official_old> data_official_old { get; set; }
        public virtual DbSet<data_official_old_copy> data_official_old_copy { get; set; }
        public virtual DbSet<data_promo> data_promo { get; set; }
        public virtual DbSet<data_promo_statistic> data_promo_statistic { get; set; }
        public virtual DbSet<data_quanmin> data_quanmin { get; set; }
        public virtual DbSet<data_total> data_total { get; set; }
        public virtual DbSet<data_warning> data_warning { get; set; }
        public virtual DbSet<failed_jobs> failed_jobs { get; set; }
        public virtual DbSet<game> game { get; set; }
        public virtual DbSet<game_520> game_520 { get; set; }
        public virtual DbSet<game_520_player> game_520_player { get; set; }
        public virtual DbSet<game_customer_service> game_customer_service { get; set; }
        public virtual DbSet<game_player> game_player { get; set; }
        public virtual DbSet<jackpot> jackpot { get; set; }
        public virtual DbSet<job_log> job_log { get; set; }
        public virtual DbSet<live> live { get; set; }
        public virtual DbSet<live_redbox> live_redbox { get; set; }
        public virtual DbSet<logger> logger { get; set; }
        public virtual DbSet<lottery_prize> lottery_prize { get; set; }
        public virtual DbSet<lottery_prize_entity> lottery_prize_entity { get; set; }
        public virtual DbSet<machine_check_out_factory> machine_check_out_factory { get; set; }
        public virtual DbSet<machine_check_to_place> machine_check_to_place { get; set; }
        public virtual DbSet<message> message { get; set; }
        public virtual DbSet<official_account> official_account { get; set; }
        public virtual DbSet<official_account_person> official_account_person { get; set; }
        public virtual DbSet<official_online_log> official_online_log { get; set; }
        public virtual DbSet<operate_log> operate_log { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<participator_draw> participator_draw { get; set; }
        public virtual DbSet<payment_print_info> payment_print_info { get; set; }
        public virtual DbSet<payment_print_refund> payment_print_refund { get; set; }
        public virtual DbSet<person_log> person_log { get; set; }
        public virtual DbSet<person_user> person_user { get; set; }
        public virtual DbSet<platform_operation_log> platform_operation_log { get; set; }
        public virtual DbSet<preference_printer> preference_printer { get; set; }
        public virtual DbSet<print_coupon> print_coupon { get; set; }
        public virtual DbSet<print_img_log> print_img_log { get; set; }
        public virtual DbSet<print_log> print_log { get; set; }
        public virtual DbSet<printer_channel> printer_channel { get; set; }
        public virtual DbSet<printer_operation> printer_operation { get; set; }
        public virtual DbSet<printer_warning> printer_warning { get; set; }
        public virtual DbSet<promo_loreal> promo_loreal { get; set; }
        public virtual DbSet<qa> qa { get; set; }
        public virtual DbSet<qa_tags> qa_tags { get; set; }
        public virtual DbSet<qmyx_device> qmyx_device { get; set; }
        public virtual DbSet<redbox> redbox { get; set; }
        public virtual DbSet<redbox_action> redbox_action { get; set; }
        public virtual DbSet<redbox_coin> redbox_coin { get; set; }
        public virtual DbSet<redbox_flowmeter> redbox_flowmeter { get; set; }
        public virtual DbSet<redbox_grade> redbox_grade { get; set; }
        public virtual DbSet<redbox_liveness> redbox_liveness { get; set; }
        public virtual DbSet<redbox_log> redbox_log { get; set; }
        public virtual DbSet<redbox_log_status> redbox_log_status { get; set; }
        public virtual DbSet<redbox_machine_meta> redbox_machine_meta { get; set; }
        public virtual DbSet<redbox_monitor_net> redbox_monitor_net { get; set; }
        public virtual DbSet<redbox_onlinable_meta> redbox_onlinable_meta { get; set; }
        public virtual DbSet<redbox_pv> redbox_pv { get; set; }
        public virtual DbSet<redbox_shows> redbox_shows { get; set; }
        public virtual DbSet<redbox_tags> redbox_tags { get; set; }
        public virtual DbSet<redbox_update> redbox_update { get; set; }
        public virtual DbSet<setting> setting { get; set; }
        public virtual DbSet<shows> shows { get; set; }
        public virtual DbSet<shows_online_log> shows_online_log { get; set; }
        public virtual DbSet<statistic_printer> statistic_printer { get; set; }
        public virtual DbSet<subject> subject { get; set; }
        public virtual DbSet<subject_coupon> subject_coupon { get; set; }
        public virtual DbSet<ticket> ticket { get; set; }
        public virtual DbSet<ticket_comment> ticket_comment { get; set; }
        public virtual DbSet<trophy> trophy { get; set; }
        public virtual DbSet<updates> updates { get; set; }
        public virtual DbSet<user_charge_order> user_charge_order { get; set; }
        public virtual DbSet<user_feedback> user_feedback { get; set; }
        public virtual DbSet<user_image> user_image { get; set; }
        public virtual DbSet<user_notification> user_notification { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<users_money_log> users_money_log { get; set; }
        public virtual DbSet<users_order> users_order { get; set; }
        public virtual DbSet<vb_redbox_shows> vb_redbox_shows { get; set; }
        public virtual DbSet<xmas_assist> xmas_assist { get; set; }
        public virtual DbSet<xmas_prize> xmas_prize { get; set; }
        public virtual DbSet<xmas_prize_entity> xmas_prize_entity { get; set; }
        public virtual DbSet<xmas_prize_log> xmas_prize_log { get; set; }
        public virtual DbSet<migrations> migrations { get; set; }
        public virtual DbSet<password_resets> password_resets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<activity>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.game_identity)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.game_url)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.free_scope)
                .IsUnicode(false);

            modelBuilder.Entity<activity>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<activity_privilege>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.addressable_type)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<advertise>()
                .Property(e => e.promo_name)
                .IsUnicode(false);

            modelBuilder.Entity<advertise_adv>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<advertise_redbox>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<agent_daily>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<agent_daily>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<agent_daily_detail>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<agent_daily_detail>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<agent_daily_detail>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<area>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<article_official>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_official>()
                .Property(e => e.article_url)
                .IsUnicode(false);

            modelBuilder.Entity<article_print>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_print>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_print_statistic>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_print_statistic>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_record>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<article_record>()
                .Property(e => e.article_url)
                .IsUnicode(false);

            modelBuilder.Entity<audit>()
                .Property(e => e.auditable_type)
                .IsUnicode(false);

            modelBuilder.Entity<audit>()
                .Property(e => e.channel_nickname)
                .IsUnicode(false);

            modelBuilder.Entity<audit>()
                .Property(e => e.audit_data)
                .IsUnicode(false);

            modelBuilder.Entity<audit>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<audit>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<audit_facade>()
                .Property(e => e.facadeable_type)
                .IsUnicode(false);

            modelBuilder.Entity<audit_facade>()
                .Property(e => e.auditable_type)
                .IsUnicode(false);

            modelBuilder.Entity<audit_facade>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<balance>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<bill>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<bill>()
                .Property(e => e.transaction_number)
                .IsUnicode(false);

            modelBuilder.Entity<bill>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<bill>()
                .Property(e => e.payment)
                .IsUnicode(false);

            modelBuilder.Entity<bill>()
                .Property(e => e.open_id)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.nick_name)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.corp_open_id)
                .IsUnicode(false);

            modelBuilder.Entity<channel>()
                .Property(e => e.remember_token)
                .IsUnicode(false);

            modelBuilder.Entity<channel_account_number_seed>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.company_name)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.company_address)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.legal_person)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.deposit_bank)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.bank_account)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.business_license_url)
                .IsUnicode(false);

            modelBuilder.Entity<channel_business_info>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<channel_feedback>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<channel_feedback>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<channel_feedback>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<channel_machine>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<conf_bh_sn>()
                .Property(e => e.bh)
                .IsUnicode(false);

            modelBuilder.Entity<conf_bh_sn>()
                .Property(e => e.sn)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.serial_number)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.shop_name)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.logo_url)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.value_degree)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.first_category)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.second_category)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.provider)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.coupon_type)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.ext_info)
                .IsUnicode(false);

            modelBuilder.Entity<coupon>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old_copy>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old_copy>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old_copy>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old_copy>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_old_copy>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_pay>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_pay>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_pay>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_pay>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_promo>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_promo>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_promo>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<data_agent_promo>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_coinprint>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_coinprint>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<data_coinprint>()
                .Property(e => e.agentname)
                .IsUnicode(false);

            modelBuilder.Entity<data_gucci>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<data_gucci>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<data_gucci>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<data_laneige>()
                .Property(e => e.wechat_openid)
                .IsUnicode(false);

            modelBuilder.Entity<data_laneige>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_laneige_statistic>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_laneige_statistic>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_official>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_account>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_account>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_copy>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_copy>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_copy>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_copy>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old_copy>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old_copy>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old_copy>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<data_official_old_copy>()
                .Property(e => e.extra1)
                .IsUnicode(false);

            modelBuilder.Entity<data_promo>()
                .Property(e => e.open_id)
                .IsUnicode(false);

            modelBuilder.Entity<data_promo>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_promo>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<data_promo_statistic>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_promo_statistic>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_quanmin>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<data_quanmin>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<data_warning>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<data_warning>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<data_warning>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<failed_jobs>()
                .Property(e => e.connection)
                .IsUnicode(false);

            modelBuilder.Entity<failed_jobs>()
                .Property(e => e.queue)
                .IsUnicode(false);

            modelBuilder.Entity<failed_jobs>()
                .Property(e => e.payload)
                .IsUnicode(false);

            modelBuilder.Entity<game>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<game>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<game_520>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<game_520>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<game_520_player>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<game_customer_service>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<game_customer_service>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<game_customer_service>()
                .Property(e => e.problem)
                .IsUnicode(false);

            modelBuilder.Entity<game_customer_service>()
                .Property(e => e.problem_desc)
                .IsUnicode(false);

            modelBuilder.Entity<game_customer_service>()
                .Property(e => e.image_voucher)
                .IsUnicode(false);

            modelBuilder.Entity<game_player>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<jackpot>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<jackpot>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<jackpot>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<job_log>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<job_log>()
                .Property(e => e._operator)
                .IsUnicode(false);

            modelBuilder.Entity<job_log>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<job_log>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<live>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<live>()
                .Property(e => e.in_id)
                .IsUnicode(false);

            modelBuilder.Entity<live>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<live>()
                .Property(e => e.qr_code_url)
                .IsUnicode(false);

            modelBuilder.Entity<live>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<live_redbox>()
                .Property(e => e.live_rb_code)
                .IsUnicode(false);

            modelBuilder.Entity<logger>()
                .Property(e => e.logable_type)
                .IsUnicode(false);

            modelBuilder.Entity<logger>()
                .Property(e => e.event_key)
                .IsUnicode(false);

            modelBuilder.Entity<logger>()
                .Property(e => e.log_data)
                .IsUnicode(false);

            modelBuilder.Entity<logger>()
                .Property(e => e.log_message)
                .IsUnicode(false);

            modelBuilder.Entity<logger>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.lottery_type)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.mall_id)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.reach)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.minus)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.open_date)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.end_date)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize>()
                .Property(e => e.scene_text)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.prize_code)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.reach)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.minus)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.mall_id)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.open_date)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.end_date)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.scene_text)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<lottery_prize_entity>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<machine_check_out_factory>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<machine_check_out_factory>()
                .Property(e => e.check_array)
                .IsUnicode(false);

            modelBuilder.Entity<machine_check_to_place>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<machine_check_to_place>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<machine_check_to_place>()
                .Property(e => e.check_array)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<message>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.channel)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.poster_url)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.qrcode_url)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.agent_source)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.instruction)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<official_account>()
                .Property(e => e.presentation_url)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.desc)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.machine)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.person_id)
                .IsUnicode(false);

            modelBuilder.Entity<official_account_person>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<operate_log>()
                .Property(e => e.client_ip)
                .IsUnicode(false);

            modelBuilder.Entity<operate_log>()
                .Property(e => e.identify)
                .IsUnicode(false);

            modelBuilder.Entity<operate_log>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<operate_log>()
                .Property(e => e.data)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.pay_type)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.body)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.item_key)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.event_key)
                .IsUnicode(false);

            modelBuilder.Entity<participator_draw>()
                .Property(e => e.participator_type)
                .IsUnicode(false);

            modelBuilder.Entity<participator_draw>()
                .Property(e => e.trophy_type)
                .IsUnicode(false);

            modelBuilder.Entity<participator_draw>()
                .Property(e => e.verify_code)
                .IsUnicode(false);

            modelBuilder.Entity<participator_draw>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<participator_draw>()
                .Property(e => e.event_key)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_info>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_info>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_info>()
                .Property(e => e.unique_key)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_info>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.tip)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<payment_print_refund>()
                .Property(e => e.alipay_account)
                .IsUnicode(false);

            modelBuilder.Entity<person_log>()
                .Property(e => e.user_identify)
                .IsUnicode(false);

            modelBuilder.Entity<person_log>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<person_log>()
                .Property(e => e.account_code)
                .IsUnicode(false);

            modelBuilder.Entity<person_log>()
                .Property(e => e.person_identify)
                .IsUnicode(false);

            modelBuilder.Entity<person_log>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<person_user>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<person_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<person_user>()
                .Property(e => e.other_uid)
                .IsUnicode(false);

            modelBuilder.Entity<platform_operation_log>()
                .Property(e => e.platform)
                .IsUnicode(false);

            modelBuilder.Entity<platform_operation_log>()
                .Property(e => e.account_code)
                .IsUnicode(false);

            modelBuilder.Entity<platform_operation_log>()
                .Property(e => e.trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<platform_operation_log>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<platform_operation_log>()
                .Property(e => e.ext1)
                .IsUnicode(false);

            modelBuilder.Entity<preference_printer>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<preference_printer>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<preference_printer>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<print_img_log>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<print_img_log>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<print_img_log>()
                .Property(e => e.request_host)
                .IsUnicode(false);

            modelBuilder.Entity<print_img_log>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<print_log>()
                .Property(e => e.maid)
                .IsUnicode(false);

            modelBuilder.Entity<print_log>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<print_log>()
                .Property(e => e.info)
                .IsUnicode(false);

            modelBuilder.Entity<print_log>()
                .Property(e => e.ads_url)
                .IsUnicode(false);

            modelBuilder.Entity<print_log>()
                .Property(e => e.print_log_from)
                .IsUnicode(false);

            modelBuilder.Entity<printer_channel>()
                .Property(e => e.channel_name)
                .IsUnicode(false);

            modelBuilder.Entity<printer_operation>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<printer_operation>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<printer_operation>()
                .Property(e => e.print_source)
                .IsUnicode(false);

            modelBuilder.Entity<printer_warning>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<printer_warning>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<promo_loreal>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<promo_loreal>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<promo_loreal>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<qa>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<qa>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<qa>()
                .Property(e => e.tags)
                .IsUnicode(false);

            modelBuilder.Entity<qa_tags>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<qmyx_device>()
                .Property(e => e.device_code)
                .IsUnicode(false);

            modelBuilder.Entity<qmyx_device>()
                .Property(e => e.device_name)
                .IsUnicode(false);

            modelBuilder.Entity<qmyx_device>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<qmyx_device>()
                .Property(e => e.market)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.maid)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.network_state)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.sdcard)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.shutdown_hour)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.shutdown_min)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.halt_remark)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.con_tel)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.shutdown_time)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.tv_name)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.tv_password)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.ver_type)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.ma_info)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.remote_id)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.child_cid)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.looklike)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<redbox>()
                .Property(e => e.boot_time)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_action>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_action>()
                .Property(e => e.param)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_flowmeter>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_grade>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.redbox_log_type)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.redbox_log_data)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.param1)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.param2)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log>()
                .Property(e => e.param3)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log_status>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log_status>()
                .Property(e => e.maid)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_log_status>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_machine_meta>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_machine_meta>()
                .Property(e => e.onlinable_type)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_machine_meta>()
                .Property(e => e.current_onlined)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_machine_meta>()
                .Property(e => e.locked_orders)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_machine_meta>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_monitor_net>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_monitor_net>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_onlinable_meta>()
                .Property(e => e.onlinable_type)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_onlinable_meta>()
                .Property(e => e.onlinable_id)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_onlinable_meta>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_pv>()
                .Property(e => e.m_code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.shows_qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.shows_paper_print)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.shows_control_part)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.shows_screen)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.shows_scroll)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_shows>()
                .Property(e => e.third_screen)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_tags>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_tags>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_update>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_update>()
                .Property(e => e.before_version)
                .IsUnicode(false);

            modelBuilder.Entity<redbox_update>()
                .Property(e => e.target_version)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<setting>()
                .Property(e => e.setting_value)
                .IsUnicode(false);

            modelBuilder.Entity<shows>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<shows>()
                .Property(e => e.cids)
                .IsUnicode(false);

            modelBuilder.Entity<shows>()
                .Property(e => e.shows_from)
                .IsUnicode(false);

            modelBuilder.Entity<shows>()
                .Property(e => e.ext)
                .IsUnicode(false);

            modelBuilder.Entity<shows>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<shows_online_log>()
                .Property(e => e.shows_type)
                .IsUnicode(false);

            modelBuilder.Entity<statistic_printer>()
                .Property(e => e.official_account_code)
                .IsUnicode(false);

            modelBuilder.Entity<statistic_printer>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<statistic_printer>()
                .Property(e => e.out_trade_code)
                .IsUnicode(false);

            modelBuilder.Entity<statistic_printer>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.provider)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<subject_coupon>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.pics)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.ticket_type)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.ext1)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.ext2)
                .IsUnicode(false);

            modelBuilder.Entity<ticket>()
                .Property(e => e.ext3)
                .IsUnicode(false);

            modelBuilder.Entity<ticket_comment>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<ticket_comment>()
                .Property(e => e.images)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.trophyable_type)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.trophy_type)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.first_category)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.second_category)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.rate_config)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<trophy>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<updates>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<updates>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<updates>()
                .Property(e => e.desc)
                .IsUnicode(false);

            modelBuilder.Entity<user_charge_order>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<user_charge_order>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<user_charge_order>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<user_charge_order>()
                .Property(e => e.discount)
                .IsUnicode(false);

            modelBuilder.Entity<user_charge_order>()
                .Property(e => e.unique_key)
                .IsUnicode(false);

            modelBuilder.Entity<user_feedback>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<user_feedback>()
                .Property(e => e.tip)
                .IsUnicode(false);

            modelBuilder.Entity<user_feedback>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<user_feedback>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<user_feedback>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<user_image>()
                .Property(e => e.event_key)
                .IsUnicode(false);

            modelBuilder.Entity<user_image>()
                .Property(e => e.image_url)
                .IsUnicode(false);

            modelBuilder.Entity<user_image>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<user_notification>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<user_notification>()
                .Property(e => e.sub_title)
                .IsUnicode(false);

            modelBuilder.Entity<user_notification>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.wechat_openid)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.remember_token)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.extra_data)
                .IsUnicode(false);

            modelBuilder.Entity<users_money_log>()
                .Property(e => e.types)
                .IsUnicode(false);

            modelBuilder.Entity<users_money_log>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<users_money_log>()
                .Property(e => e.data2)
                .IsUnicode(false);

            modelBuilder.Entity<users_order>()
                .Property(e => e.machine_code)
                .IsUnicode(false);

            modelBuilder.Entity<users_order>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.third_screen)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.shows_screen_adv)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.shows_control_adv)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.shows_scroll)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.show_qrcode)
                .IsUnicode(false);

            modelBuilder.Entity<vb_redbox_shows>()
                .Property(e => e.show_paper_print)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_assist>()
                .Property(e => e.machine_id)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize>()
                .Property(e => e.mall_id)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_entity>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_entity>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_entity>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_entity>()
                .Property(e => e.reach)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_entity>()
                .Property(e => e.minus)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_log>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_log>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_log>()
                .Property(e => e.mall_id)
                .IsUnicode(false);

            modelBuilder.Entity<xmas_prize_log>()
                .Property(e => e.machine_id)
                .IsUnicode(false);

            modelBuilder.Entity<migrations>()
                .Property(e => e.migration)
                .IsUnicode(false);

            modelBuilder.Entity<password_resets>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<password_resets>()
                .Property(e => e.token)
                .IsUnicode(false);
        }
    }
}
