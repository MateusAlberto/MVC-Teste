using ProjetoTeste.Models;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoTeste.Services
{
    public class DepartmentService
    {
        private readonly ProjetoTesteContext _context;

        public DepartmentService(ProjetoTesteContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
