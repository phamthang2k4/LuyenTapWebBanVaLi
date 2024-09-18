using ThucHanhWebMVC1.Models;
namespace ThucHanhWebMVC1.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaisp);

        TLoaiSp Update(TLoaiSp loaisp);

        TLoaiSp Delete(String maloaiSp);

        TLoaiSp GetLoaiSp(String maloaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
