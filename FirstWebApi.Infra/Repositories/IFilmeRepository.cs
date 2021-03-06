using FirstWebApi.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Infra.Data.Repositories
{
    public interface IFilmeRepository
    {
        IEnumerable<FilmeDTO> GetAll();

        FilmeDTO Insert(FilmeDTO filmeDTO);

        FilmeDTO Update(FilmeDTO filmeDTO);

    }
}
