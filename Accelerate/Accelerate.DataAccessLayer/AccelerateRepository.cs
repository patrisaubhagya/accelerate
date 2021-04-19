using Accelerate.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace Accelerate.DataAccessLayer
{
    public class AccelerateRepository
    {
        AccelerateDBContext context;
        
        public AccelerateRepository()
        {
            context = new AccelerateDBContext();
        }

        public List<DashBoard> GetDashboard()
        {
            var categoriesList = context.DashBoards.ToList();
            return categoriesList;
        }

        public List<DashBoard> GetVerticals()
        {
            var listVertical = context.DashBoards.ToList();
            return listVertical;
        }

        public List<DashBoard> filterHorizontal(string vertical)
        {
            var listHorizontals = context.DashBoards.Where(v => v.Vertical == vertical).ToList();
            return listHorizontals;
        }

        public List<DashBoard> filterSearchWords(string vertical,string horizontal)
        {
            var listWords = context.DashBoards.Where(s => s.Horizontal == horizontal && s.Vertical==vertical).ToList();
            return listWords;
        }

        public List<DashBoard> filterSearchWordsLike(string pattern)
        {
            List<DashBoard> listWords = context.DashBoards.Where(p => p.SearchWords.Contains(pattern)).ToList();
            return listWords;
        }

    }
}
