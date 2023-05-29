using CharlesApi.Request.Beneficiario;
using CharlesApi.Result.Beneficiario;

namespace CharlesApi.Data.Beneficiario
{
    public interface IBeneficiarioService
    {
        ListadoBeneficiarioResult ObtenerBeneficiarios();
        ListadoBeneficiarioResult BuscarBeneficiarios();
        BeneficiarioResult ObtenerBeneficiario();
        BeneficiarioResult CrearBeneficiario(BeneficiarioRequest beneficiarioRequest);
        BeneficiarioResult ActualizarBeneficiario(BeneficiarioRequest beneficiarioRequest);

        BeneficiarioResult EliminarBeneficiario();

        }
}