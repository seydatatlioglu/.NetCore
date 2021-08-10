using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(); //Tüm kategoriyi sırala
        Category GetById(int categoryId); //tek bir id çekecek listeye gerek yok
    }
}
