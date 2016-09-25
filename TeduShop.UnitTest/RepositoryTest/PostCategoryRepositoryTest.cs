using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass] //Chỉ ra Nó sẽ hiểu bên cửa sổ TestExplorer
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory; //  Cần đối để tương tác với CSDL
        IPostCategoryRepository objRepository; // Cần đối để tương tác với CSDL
        IUnitOfWork unitOfWork; //Cần đối để tương tác với CSDL 

        [TestInitialize]             // 
        public void Initialize()     // TestInitialize Nó có phương thức, đầu tiên để thiết lập THAM SỐ, ĐỐI TƯỢNG chạy ứng dụng
        {
            dbFactory = new DbFactory(); //
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);// Contrastor
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }

    }
}