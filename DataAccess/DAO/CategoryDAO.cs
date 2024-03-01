using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class CategoryDAO
    {
        private readonly eStore2Context _context; 
        public CategoryDAO(eStore2Context context) {
         _context = context;
        }

        public  IEnumerable<Category> GetAll()
        {
            var list =  _context.Categories.ToList();
            return list;
        }
    }
}
