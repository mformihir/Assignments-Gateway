using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SourceControlFinalAssignment.Models;

namespace SourceControlFinalAssignment.DAL
{
    //To initialize/populate Database with Test Data
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            
        }

    }
}