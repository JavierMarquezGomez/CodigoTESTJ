using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionConsol
{
    public class Androide
    {

        #region Inyeccion por SETTER
        /*
             Opcion 1 Inyeccion por Setter        
        */

        //Inyeccion de dependencia por SETTER
        // public ICuerpo cuerpo { set; get; }

        #endregion


        #region  Inyeccion por INTERFAZ  

        /*
         * public ICuerpo _cuerpo;

        public void SetCuerpo(ICuerpo cuerpo)
        {
            _cuerpo = cuerpo;
        }
        */
        #endregion

        #region Inyeccion por CONSTRUCTOR

        /// <summary>
        /// Constructor que permite agregar la interfaz para su ejecucion
        ///  <summary>

        public ICuerpo _cuerpo;
       // public IAccion _accion;
        public IOtro _otro;
        public Androide(ICuerpo cuerpo , IOtro otro)
        {
            _cuerpo = cuerpo;
            _otro = otro;
        }

        #endregion

        public void Avanzar()
        {
            if(_cuerpo != null)
            {
                _cuerpo.Avanzar();
            }
        }

        public void Retroceder()
        {
            if(_cuerpo != null)
            {
                _cuerpo.Retroceder();
            }
        }

        public void Disparar()
        {
                if(_cuerpo != null)
            {
                _cuerpo.Disparar();
            }
        }
        //public void Rodar()
        //{
        //    if( _accion != null)
        //    {
        //        _accion.Rodar();
        //    }
            
        //}

        public void Rodar()
        {
            if(_otro != null)
            {
                _otro.Rodar();
            }
        }

        public void Ejercitar()
        {
            if(_otro != null)
            {
                _otro.Ejercitar();
            }
        }
    }
}
