using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Computador
    {
        private int idComputador;
        private string marca;
        private string modelo;
        private string placaMae;
        private int memoriaRAM;
        private int hdArmazenamento;
        private string hdMarca;
        private string velocidadeProcessador;
        private string foto;
        private Usuario empresa;

        public Computador()
        {

        }

        public Computador(int idComputador, string marca, string modelo, string placaMae,
            int memoriaRAM, int hdArmazenamento, string hdMarca, string velocidadeProcessador, string foto)
        {
            IdComputador = idComputador;
            Marca = marca;
            Modelo = modelo;
            PlacaMae = placaMae;
            MemoriaRAM = memoriaRAM;
            HdArmazenamento = hdArmazenamento;
            HdMarca = HdMarca;
            VelocidadeProcessador = velocidadeProcessador;
            Foto = foto;
        }

        public int IdComputador
        {
            get
            {
                return idComputador;
            }
            set
            {
                idComputador = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public string PlacaMae
        {
            get
            {
                return placaMae;
            }
            set
            {
                placaMae = value;
            }
        }

        public int MemoriaRAM
        {
            get
            {
                return memoriaRAM;
            }
            set
            {
                memoriaRAM = value;
            }
        }

        public int HdArmazenamento
        {
            get
            {
                return hdArmazenamento;
            }
            set
            {
                hdArmazenamento = value;
            }
        }

        public string HdMarca
        {
            get
            {
                return hdMarca;
            }
            set
            {
                hdMarca = value;
            }
        }

        public string VelocidadeProcessador
        {
            get
            {
                return velocidadeProcessador;
            }
            set
            {
                velocidadeProcessador = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }

        public override string ToString()
        {
            return $"Id do PC: { idComputador }, Marca: { marca }, Modelo: { modelo }, Placa Mãe: { placaMae }, " +
                $" Memória RAM: { memoriaRAM }, HD: { hdArmazenamento }, Marca do HD: { hdMarca }, Velocidade do Processador: { velocidadeProcessador } " +
                $" Foto: { foto } ";
        }
    }
}
