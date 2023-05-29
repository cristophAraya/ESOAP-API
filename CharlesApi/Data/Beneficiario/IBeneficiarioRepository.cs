using CharlesApi.Entities.Beneficiario;

namespace CharlesApi.Repository.Beneficiario
{
    public interface IBeneficiarioRepository
    {
        IList<BeneficiarioModel> ObtenerBeneficiarios();
        IList<BeneficiarioModel> BuscarBeneficiarios(BeneficiarioModel beneficiarioModel);
        BeneficiarioModel ObtenerBeneficiario(BeneficiarioModel beneficiarioModel);
        BeneficiarioModel CrearBeneficiario(BeneficiarioModel beneficiarioModel);
        bool ActualizarBeneficiario(BeneficiarioModel beneficiarioModel);
        bool EliminarBeneficiario();

    }
}