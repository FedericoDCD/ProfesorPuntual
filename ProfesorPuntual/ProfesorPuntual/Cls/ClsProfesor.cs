using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfesorPuntual.Cls
{
    class ClsProfesor
    {
        //ATRIBUTOS
        private String NroFuncionario;
        private String Nombre;
        private String Mail;
        private String Numero;
        //GETTERS Y SETTERS
        public string GetNroFuncionario() {
            return NroFuncionario;
        }
        public void SetNroFuncionario(string NroFuncionario) {
            this.NroFuncionario = NroFuncionario;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetMail()
        {
            return Mail;
        }
        public void SetMail(String Mail)
        {
            this.Mail = Mail;
        }
        public string GetNumero()
        {
            return Nombre;
        }
        public void SetNumero(String Numero)
        {
            this.Numero = Numero;
        }
        //CONSTRUCTORES
        public ClsProfesor(String NroFuncionario, String Nombre, String Mail, String Numero) {
            this.NroFuncionario = NroFuncionario;
            this.Nombre = Nombre;
            this.Mail = Mail;
            this.Numero = Numero;
        }
        public ClsProfesor() {//Constructor por defecto

        }
        //MÉTODOS
        public void ADocente(ClsProfesor ObjProfesor)
        {//Doy de alta un docente
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores del Docente
            string NroFuncionario = ObjProfesor.GetNroFuncionario();
            string Nombre = ObjProfesor.GetNombre();
            string Mail = ObjProfesor.GetMail();
            string Numero = ObjProfesor.GetNumero();
            using (SqlCommand comand = new SqlCommand("PRAInsertarDocente", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@NroFuncionario", NroFuncionario));
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    comand.Parameters.Add(new SqlParameter("@Mail", Mail));
                    comand.Parameters.Add(new SqlParameter("@Celular", Numero));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void ADestinatario(ClsDestinatario ObjDestinatario)
        {//Doy de alta un docente
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores del Destinatario
            string Curso = ObjDestinatario.GetCurso();
            string Nombre = ObjDestinatario.GetNombre();
            string Mail = ObjDestinatario.GetMail();
            string Numero = ObjDestinatario.GetNumero();
            int IDTipo = ObjDestinatario.GetIDTipo();
            using (SqlCommand comand = new SqlCommand("PRAInsertarDestinatarios", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Curso", Curso));
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    comand.Parameters.Add(new SqlParameter("@Mail", Mail));
                    comand.Parameters.Add(new SqlParameter("@Numero", Numero));
                    comand.Parameters.Add(new SqlParameter("@IDTipo", IDTipo));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void AMensajes(ClsMensaje ObjMensaje)
        {//Doy de alta un docente
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores del Destinatario
            string Asunto = ObjMensaje.GetAsunto();
            string Contenido = ObjMensaje.GetContenido();
            DateTime Fecha = ObjMensaje.GetFecha();
            int IDCausal = ObjMensaje.GetIDCausal();
            using (SqlCommand comand = new SqlCommand("PRAInsertarMensajes", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Asunto", Asunto));
                    comand.Parameters.Add(new SqlParameter("@Contenido", Contenido));
                    comand.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                    comand.Parameters.Add(new SqlParameter("@IDCausal", IDCausal));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void AMensajeDestinatario(ClsMensaje ObjMensaje)
        {//Doy de alta un docente
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores del Destinatario
            string Asunto = ObjMensaje.GetAsunto();
            string Contenido = ObjMensaje.GetContenido();
            DateTime Fecha = ObjMensaje.GetFecha();
            int IDCausal = ObjMensaje.GetIDCausal();
            using (SqlCommand comand = new SqlCommand("PRAInsertarMensajeDestinatario", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@IDMensaje", Asunto));
                    comand.Parameters.Add(new SqlParameter("@IDDestinatario", Contenido));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable BuscarDocentes()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarDocentes", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarFuncionario()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarFuncionarios", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarDelegados()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarDelegados", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarDestinatarios()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarDestinatarios", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarMensajes()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarMensajes", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
        public System.Data.DataTable BuscarTipoDestinatario()
        {
            CLSBDProfesor BD = new CLSBDProfesor();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarTipoDestinatarios", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
    }
}
