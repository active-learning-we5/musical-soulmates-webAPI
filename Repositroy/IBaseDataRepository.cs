using System;

namespace asus.Desktop.musical-soulmates-webAPI.Repositroy
{
    public class IBaseDataRepository
{
    interface IBaseDataRepository : IRepository<BaseData, int>
    { // 
        IEnumerable<BaseData> GetAll();

        IEnumerable<BaseData> Get(Func<BaseData, bool> predict);

        BaseData Get(int id);

        int SaveChanges();

        IEnumerable<BaseData> GetByParentCode(string lang, string code);
    }


    class BaseDataRepository : IBaseDataRepository
    { // 
        BaseDataRepository(MusicSoulmatesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<BaseData> GetAll()
        {
            return this.dbContext.BaseData.ToList();
        }

        public IEnumerable<BaseData> Get(Func<BaseData, bool> predict)
        {
            return this.dbContext.BaseData.Where(predict).ToList();
        }

        public BaseData Get(int id)
        {
            return this.dbContext.BaseData.Where(d => d.Id == id).FirstOrDefault();
        }

        public int SaveChanges()
        {
            returnthis.dbContext.SaveChanges();
        }

        public IEnumerable<BaseData> GetByParentCode(string lang, string code)
        {
            if (lang == "en")
                return Get(x => x.Parent.Code == code);
            return this.dbContext.BaseDataTranslations.Where(d => d.BaseData.Parent.Code == code && d.lang == lang).ToList();
        }
    }

}
}
