﻿using System;

namespace FlyweightOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // İstemci için örnek bir FlyWeight nesne örneği dizisi oluşturulur
            SoldierType[] soldiers = { SoldierType.Private, SoldierType.Private, SoldierType.Sergeant, SoldierType.Private, SoldierType.Sergeant };


            // FlyWeight Factory nesnesi örneklernir
            SoldierFactory factory = new SoldierFactory();

            // Extrinsic değerler set edilir
            int localtionX = 10;
            int locationY = 10;

            foreach (SoldierType soldier in soldiers)
            {
                localtionX += 10;
                locationY += 5;

                // O anki Soldier tipi için MoveTo operasyonu çağırılmadan önce fabrika nesnesinden tedarik edilir
                Soldier sld = factory.GetSoldier(soldier);

                // FlyWeight nesnesi üzerinden talep edilen operasyon çağrısı gerçekleştirilir
                sld.MoveTo(localtionX, locationY);

            }
        }
    }
}
