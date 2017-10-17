using RedBox.Models.RedBox;

namespace RedBox.IDAL
{
    public interface ICityRepository:InterfaceBaseRepository<printer_channel>
    {
        dynamic GetCitiesInfo();

        dynamic getCollapseCities();
    }
}
