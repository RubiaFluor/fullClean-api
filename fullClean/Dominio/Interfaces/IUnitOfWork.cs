using System;
namespace fullClean.Dominio.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
      IProducts products { get; }
      void saveData();

    }
}