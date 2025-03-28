using System.Collections.Generic;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using L01P022022_SU_650.Models;

namespace L01P022022_SU_650.Models
{
    
    public class notasbdcontext : DbContext
    {
        public notasbdcontext(DbContextOptions options) : base(options) 
        {
           
        
        
        } 
       
    
public DbSet<L01P022022_SU_650.Models.departamentos> departamentos { get; set; } = default!;
    
public DbSet<L01P022022_SU_650.Models.facultades> facultades { get; set; } = default!;
    
public DbSet<L01P022022_SU_650.Models.materias> materias { get; set; } = default!;
    
public DbSet<L01P022022_SU_650.Models.alumnos> alumnos { get; set; } = default!;
       
        
    
    }
}

