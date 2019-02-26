using Blog.Core.Model.Models;
using Blog.Core.ServicesBase;
using Blog.Core.IServices;
using Blog.Core.IRepository;
using System.Threading.Tasks;
using System.Linq;

namespace Blog.Core.FrameWork.Services
{
    /// <summary>
    /// sysUserInfoServices
    /// </summary>	
    public class sysUserInfoServices : BaseServices<sysUserInfo>, IsysUserInfoServices
    {

    }
}

//----------sysUserInfo结束----------
