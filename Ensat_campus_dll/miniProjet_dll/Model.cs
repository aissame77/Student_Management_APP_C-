using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using System.Data.SqlClient;
namespace miniProjet_dll
{
    public class Model
    {
        public int id=0;
        private string sql = "";

        public Dictionary<string, T> ToDictionary<T>(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }
        //public int save()
        //{
        //    Dictionary<String, String> dico = new Dictionary<String, String>();
        //    dico = ToDictionary<String>(this);



        //    String sql = "insert into " + this.GetType().Name + " values(";




        //    foreach (KeyValuePair<String, String> l in dico)
        //    {
        //        sql += "'" + l.Value + "' ,";
        //    }



        //    int Taille = sql.Length;
        //    Taille -= 2;

        //    sql = sql.Remove(Taille);

        //    sql += ");";

        //    //Console.WriteLine(sql);
        //    //return 0;

        //    return Connexion.iud(sql);
        //}
        public int delete()
        {
            int id = this.id;
            string sql = "delete from "+ this.GetType().Name +" where id=" + id+" ;";
            return Connexion.iud(sql);
        }
        //public int save()
        //{
        //    Dictionary<String, String> dico = new Dictionary<String, String>();
        //    dico = ToDictionary<String>(this);
        //    List<String> LC = Connexion.getChamps_table(this.GetType().Name);

        //    dynamic inst = this.find();

        //    if (inst is null)
        //    {
        //        sql = "insert into " + this.GetType().Name + " values(";

        //        foreach (KeyValuePair<String, String> l in dico)
        //        {
        //            //Console.WriteLine(l);
        //            if (l.Key == "id" )
        //                continue;
        //            sql += "'" + l.Value + "' ,";
        //        }


        //        int Taille = sql.Length;
        //        Taille -= 2;

        //        sql = sql.Remove(Taille);

        //        sql += ");";
        //        Console.WriteLine(sql);
        //        //return 0;
        //    }
        //    else
        //    {
        //        int i = 0;

        //        String sql = "update " + GetType().Name + "  set ";
        //        //sql += LC[0] + " = " + "" + dico["id"]+ "" + ",";

        //        foreach (KeyValuePair<String, String> l in dico)
        //        {
        //            //Console.WriteLine(LC[i]);
        //            if (l.Key == "id" || l.Key == "code")
        //                continue;
        //            // sql += LC[0] + " = " + "" + l.Value + "" + ",";
        //            sql += LC[i] + " = " + "'" + l.Value + "'" + ",";

        //            i++;
        //        }



        //        //i++;


        //        int Taille = sql.Length;
        //        Taille -= 2;

        //        sql = sql.Remove(Taille);

        //        sql += "' where id = " + id + " ;";
        //        return Connexion.iud(sql);
        //        // Console.WriteLine(sql);

        //    }


        //    // return 0;
        //    Console.WriteLine(sql);
        //    return Connexion.iud(sql);
        //}
        public dynamic DictionaryToObject(Dictionary<string, object> dict)
        {
            IDictionary<string, object> eo = new ExpandoObject() as IDictionary<string, object>;

            foreach (KeyValuePair<string, object> kvp in dict)
            { eo.Add(kvp); }


            return eo;
        }
        //public dynamic find()
        //{
        //    Dictionary<string, object> dico = new Dictionary<string, object>();
        //    Dictionary<string, string> ch = new Dictionary<string, string>();
        //    String sql = "select * from " + this.GetType().Name + " where id=" + id;



        //    List<String> l = Connexion.getChamps_table(this.GetType().Name);
        //    IDataReader Dr = Connexion.Select(sql);




        //    int i = 0;

        //    while (Dr.Read())

        //        foreach (String item in l)
        //        {



        //            dico.Add(item, (String)Dr.GetString(i));


        //            i++;


        //        }

        //    Dr.Close();

        //    return DictionaryToObject(dico);

        //}
        public dynamic find()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> dico2 = new Dictionary<string, string>();
            sql = "select * from " + this.GetType().Name + " where id=" + id;

            IDataReader dataReader = Connexion.Select(sql);
            if (dataReader.Read())
            {
                Console.WriteLine("existe");
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    dico.Add(dataReader.GetName(i), dataReader.GetValue(i));
                }
                dataReader.Close();
                return DictionaryToObject(dico);

            }
            else
            {
                Console.WriteLine("n'existe pas");
                dataReader.Close();
                return null;

            }

        }




        public List<dynamic> select()
        {
            Dictionary<String, String> dict = new Dictionary<String, String>();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dict = ToDictionary<String>(this);

            List<dynamic> LD = new List<dynamic>();

            List<String> L = Connexion.getChamps_table(GetType().Name);

            sql = "select * from " + GetType().Name + " where ";


            int i = 0;


            foreach (KeyValuePair<String, String> item in dict)
            {
                //Console.WriteLine(LC[i]);
                if (item.Value != null & item.Value != "0")
                {


                    sql += L[i] + " = " + "'" + item.Value + "'" + " and ";

                }
                i++;
            }


            int Taille = sql.Length;
            Taille -= 5;

            sql = sql.Remove(Taille);
            sql += ";";

            IDataReader Dr = Connexion.Select(sql);

            int n = 0;

            while (Dr.Read())

            {

                for (; n < L.Count; n++)
                {


                    dico.Add(L[n], (object)Dr[n]);


                }

                LD.Add(dico);
                n = 0;
                dico = new Dictionary<string, object>();
                //Console.WriteLine("****");
            }

            Dr.Close();

            return LD;


        }

        public static List<dynamic> all<T>()
        {

            List<String> ls = Connexion.getChamps_table(typeof(T).Name);
            string sql = "GetEtudiant";

            List<dynamic> l = new List<dynamic>();
            int i;
            IDataReader dr = Connexion.Select(sql);
            while (dr.Read())
            {

                //Creates an instance of the specified type using the constructor that best matches the specified parameters.

                for (i = 0; i < ls.Count; i++)
                {

                    l.Add(dr.GetString(i));

                }
               

            }
            dr.Close();
            //Console.WriteLine(sql);
            return l;
        }
        public List<dynamic> All()
        {
            List<dynamic> l = new List<dynamic>();
            String sql = "select * from " + this.GetType().Name;
            List<String> le = Connexion.getChamps_table(this.GetType().Name);
            IDataReader dr = Connexion.Select(sql);
            //dynamic D = new ExpandoObject() as  dynamic ;




            while (dr.Read())
            {
                for (int i = 0; i < le.Count; i++)
                {
                    l.Add(dr.GetString(i));

                }
                //l.Add("******");
            }
            dr.Close();



            return l;
        }

        
       
        public int delete(String pro = "")
        {


            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                FieldInfo[] getchamps = this.GetType().GetFields();
                for (int i = 0; i < getchamps.Length; i++)
                {
                    if (getchamps[i].Name == "id") continue;
                    parameters.Add(getchamps[i].Name, getchamps[i].GetValue(this));
                }

                return Connexion.IUD(pro, parameters);
                // Console.WriteLine(sql);
                //return 0;
            }
            catch (Exception e)
            {
                String sql = "Delete from " + this.GetType().Name + " where id = " + id;
                return Connexion.iud(sql);
            }
            return Connexion.iud(sql);

        }
        public int save(string pro = "")
        {
            if (id == 0)
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    FieldInfo[] getchamps = this.GetType().GetFields();
                    for (int i = 0; i < getchamps.Length; i++)
                    {
                        if (getchamps[i].Name == "id") continue;
                        parameters.Add(getchamps[i].Name, getchamps[i].GetValue(this));
                    }

                    return Connexion.IUD(pro, parameters);

                }
                catch (Exception ex)
                {
                    string sql = "insert into " + this.GetType().Name + " (";
                    FieldInfo[] getchamps = this.GetType().GetFields();
                    for (int i = 0; i < getchamps.Length; i++)
                    {
                        if (getchamps[i].Name == "id") continue;
                        sql += getchamps[i].Name + ",";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ") values (";
                    for (int i = 0; i < getchamps.Length; i++)
                    {
                        if (getchamps[i].Name == "id") continue;
                        sql += "'" + getchamps[i].GetValue(this) + "',";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ");";
                    Console.WriteLine(sql);
                    return Connexion.iud(sql);
                }
            }
            else
            {
                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    FieldInfo[] getchamps = this.GetType().GetFields();
                    for (int i = 0; i < getchamps.Length; i++)
                    {
                        parameters.Add(getchamps[i].Name, getchamps[i].GetValue(this));
                    }

                    return Connexion.IUD(pro, parameters);

                }
                catch (Exception ex)
                {
                    string sql = "Update " + this.GetType().Name + " set ";
                    FieldInfo[] getchamps = this.GetType().GetFields();
                    for (int i = 0; i < getchamps.Length; i++)
                    {
                        if (getchamps[i].Name == "id") continue;
                        sql += getchamps[i].Name + "='" + getchamps[i].GetValue(this) + "',";

                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += " where id = " + this.id + ";";
                    Console.WriteLine(sql);
                    return Connexion.iud(sql);
                }
            }
        }
        public static dynamic Find<T>()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            string sql = "select * from " + typeof(T).Name ;



            List<String> l = Connexion.getChamps_table(typeof(T).Name);
            IDataReader Dr = Connexion.Select(sql);





            int i = 0;
            while (Dr.Read())
                

            foreach (String item in l)
                {



                    dico.Add(item, (object)Dr[i]);


                    i++;


                }

            Dr.Close();



            return dico;


        }
    }
}
