using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax {
    class Program {
        delegate bool VergleichsDelegate ( int x , int y );

        static bool IstKleiner ( int a , int b ) {
            return a < b;
        }

        static bool IstGrösser ( int a , int b ) {
            return a > b;
        }

        static void Main ( string [ ] args ) {
            Random rand = new Random ( );
            int [ ] array = new int [ 20 ];

            for ( int i = 0 ; i < array.Length ; i++ ) {
                array [ i ] = rand.Next ( 1 , 101 );
                Console.WriteLine ( "Random Number [{0,3:d}]: " + array [ i ] , i );
            }

            Console.WriteLine ( "Limit Idx (IstKleiner): " + Limit ( array , IstKleiner ) );
            Console.WriteLine ( "Limit Idx (IstGrösser): " + Limit ( array , IstGrösser ) );
        }

        private static int Limit ( int [ ] array , VergleichsDelegate func ) {
            int num = array [ 0 ];
            int idx = 0;

            for ( int i = 1 ; i < array.Length ; i++ ) {
                if ( !func ( num , array [ i ] ) ) {
                    num = array [ i ];
                    idx = i;
                }
            }

            Console.WriteLine ( "Value = " + num );
            Console.WriteLine ( "Index = " + idx );

            return idx;
        }
    }
}
