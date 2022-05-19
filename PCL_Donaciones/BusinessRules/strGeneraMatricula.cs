using PCL_Donaciones.str;

namespace PCL_Donaciones.BusinessRules
{
    public class strGeneraMatricula
    {
        public string CrearMatricula(strDonador donador, string donadorPadre = null)
        {
            return donador.TipoDonador +
                donador.FechaReg.Year.ToString().Substring(2, 2) +
                donador.FechaReg.Month.ToString("00") +
                donador.FechaReg.Day.ToString("00") +
                donador.Sexo +
                donador.ApellidoPat.Substring(0, 1) +
                donador.Nombre.Substring(0, 1) +
                donador.Id.ToString("0000000");

            //if (donador.TipoDonador == "LID")
            //{
            //    return donador.TipoDonador +
            //        "000" +
            //        donador.FechaReg.Year.ToString().Substring(2, 2) + 
            //        donador.FechaReg.Month.ToString("00") + 
            //        donador.FechaReg.Day.ToString("00") +
            //        donador.ApellidoPat.Substring(0, 2) +
            //        ((String.IsNullOrEmpty(donador.ApellidoMat.Substring(0, 2)) == true) ? "XX" :
            //        donador.ApellidoMat.Substring(0, 2)) +
            //        donador.Nombre.Substring(0, 2) +
            //        donador.Sexo + Guid.NewGuid().ToString().Substring(0, 4) + donador.Id.ToString();
            //}
            //else
            //{
            //    return donador.TipoDonador +
            //        donadorPadre +
            //        donador.FechaReg.Year.ToString().Substring(2, 2) + 
            //        donador.FechaReg.Month.ToString("00") + 
            //        donador.FechaReg.Day.ToString("00") +
            //        donador.ApellidoPat.Substring(0, 2) +
            //        ((String.IsNullOrEmpty(donador.ApellidoMat.Substring(0, 2)) == true) ? "XX" :
            //        donador.ApellidoMat.Substring(0, 2)) +
            //        donador.Nombre.Substring(0, 2) +
            //        donador.Sexo + Guid.NewGuid().ToString().Substring(0, 4) + donador.Id.ToString();
            //}
        }
    }
}