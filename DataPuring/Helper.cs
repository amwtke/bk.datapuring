using BK.CommonLib.Util.HttpUtil;
using BK.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPuring
{
    public static class Helper
    {
        public static async Task<List<Guid>> GetUUIDs()
        {
            string url = Form1.GetHost + "acerro";
            return await Get.GetJsonAsync<List<Guid>>(url);
        } 

        public static async Task<List<UserAcademic>> GetUserAcademicByUuid(Guid uuid)
        {
            string url = Form1.GetHost + "GetErrorUserAcademicById?uuid="+uuid.ToString();
            return await Get.GetJsonAsync<List<UserAcademic>>(url);
        }

        public static async Task<String> SaveOrUpdateAcademic(UserAcademic input)
        {
            string url = Form1.GetHost + "SaveOrUpdateUserAcademic";
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("UserAcademic.id", input.Id.ToString());
            if (input.AccountEmail_uuid.Equals(Guid.Empty))
                return "error";
            dic.Add("UserAcademic.AccountEmail_uuid", input.AccountEmail_uuid.ToString());
            dic.Add("UserAcademic.Association", input.Association);
            dic.Add("UserAcademic.AssociationPost", input.AssociationPost);
            dic.Add("UserAcademic.Fund", input.Fund);
            dic.Add("UserAcademic.FundPost", input.FundPost);
            dic.Add("UserAcademic.Magazine", input.Magazine);
            dic.Add("UserAcademic.MagazinePost", input.MagazinePost);
            string retStr = await BK.CommonLib.Util.HttpUtil.RequestUtility.HttpPostAsync(url, formData: dic);
            return retStr;
        }
    }
}
