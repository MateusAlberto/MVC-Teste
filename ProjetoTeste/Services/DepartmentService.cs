using ProjetoTeste.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoTeste.Services
{
    public class DepartmentService
    {
        private readonly ProjetoTesteContext _context;

        public DepartmentService(ProjetoTesteContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
