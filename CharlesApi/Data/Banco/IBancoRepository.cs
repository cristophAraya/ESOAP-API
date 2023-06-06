using CharlesApi.Entities.Banco;

namespace CharlesApi.Repository.Banco
{
    public interface IBancoRepository
    {
        public BancoModel ObtenerBanco(BancoModel bancoModel);
    }
}