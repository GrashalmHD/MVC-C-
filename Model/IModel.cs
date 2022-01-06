using System;

namespace Model
{
    interface IModel{
        public void run();

        public void verifyAndConvertData();
        public void refresh();
    }   
}