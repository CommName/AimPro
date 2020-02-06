using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient.Controllers
{
    class AmmoController
    {
        private int[] nizPusaka;
        private int selektor;
        public AmmoController(int[] niz) {
            this.nizPusaka = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                nizPusaka[i] = niz[i];
            }
            this.selektor = this.nizPusaka.Length - 1;
        }

        public bool shoot() {
            nizPusaka[selektor]--;
            if (nizPusaka[selektor] == 0)
            {
                this.selektor = this.nizPusaka.Length - 1;
                return false;
            }
            return true;
        }

        public bool setBazooka(){
            if (nizPusaka[0] > 0)
            {
                this.selektor = 0;
                return true;
            }
            else
                return false;
        }

        public bool setPiercing(){
            if (nizPusaka[1] > 0)
            {
                this.selektor = 1;
                return true;
            }
            else
                return false;
        }
        public bool setRegular(){
            if (nizPusaka[this.nizPusaka.Length - 1] > 0)
            {
                this.selektor = this.nizPusaka.Length - 1;
                return true;
            }
            else
                return false;
        }

        public int getBazooka() {
            return nizPusaka[0];
        }

        public int getPiercing() {
            return nizPusaka[1];
        }

        public int getRegular() {
            return nizPusaka[2];
        }
    }
}
