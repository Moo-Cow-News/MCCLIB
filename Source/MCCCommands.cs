using System;
using System.Collections.Generic;
using System.Collections;


namespace MCCLIB.commands {
    public static class Calculator {

        public static int Add(int val1, int val2, int val3=0, int val4=0, int val5=0, int val6=0, int val7=0, int val8=0) {

            return val1+val2+val3+val4+val5+val6+val7+val8;       

        }

        public static float Add(float val1, float val2, float val3=0, float val4=0, float val5=0, float val6=0, float val7=0, float val8=0) {

            return val1+val2+val3+val4+val5+val6+val7+val8;       

        }
        public static double Add(double val1, double val2, double val3=0, double val4=0, double val5=0, double val6=0, double val7=0, double val8=0) {

            return val1+val2+val3+val4+val5+val6+val7+val8;       

        }

        public static int Subtract(int val1, int val2, int val3=0, int val4=0, int val5=0, int val6=0, int val7=0, int val8=0) {

            return val1-val2-val3-val4-val5-val6-val7-val8;       

        }
        public static float Subtract(float val1, float val2, float val3=0, float val4=0, float val5=0, float val6=0, float val7=0, float val8=0) {

            return val1-val2-val3-val4-val5-val6-val7-val8;       

        }

        public static double Subtract(double val1, double val2, double val3=0, double val4=0, double val5=0, double val6=0, double val7=0, double val8=0) {

            return val1-val2-val3-val4-val5-val6-val7-val8;       

        }

        public static int Multiply(int val1, int val2, int val3=1, int val4=1, int val5=1, int val6=1, int val7=1, int val8=1) {

            return val1*val2*val3*val4*val5*val6*val7*val8;       

        }

        public static float Multiply(float val1, float val2, float val3=1, float val4=1, float val5=1, float val6=1, float val7=1, float val8=1) {

            return val1*val2*val3*val4*val5*val6*val7*val8;       

        }

        public static double Multiply(double val1, double val2, double val3=1, double val4=1, double val5=1, double val6=1, double val7=1, double val8=1) {

            return val1*val2*val3*val4*val5*val6*val7*val8;       

        }

        public static int Divide(int val1, int val2, int val3=1, int val4=1, int val5=1, int val6=1, int val7=1, int val8=1) {

            return val1/val2/val3/val4/val5/val6/val7/val8;       

        }

        public static float Divide(float val1, float val2, float val3=1, float val4=1, float val5=1, float val6=1, float val7=1, float val8=1) {

            return val1/val2/val3/val4/val5/val6/val7/val8;       

        }

        public static double Divide(double val1, double val2, double val3=1, double val4=1, double val5=1, double val6=1, double val7=1, double val8=1) {

            return val1/val2/val3/val4/val5/val6/val7/val8;       

        }

    }
    
    
    public class DoubleDataList<T1, T2> {

        public class DoubleData {
            public T1 value1;
            public T2 value2;

            public DoubleData(T1 v1, T2 v2) {
                value1 = v1;
                value2 = v2;
            }

            public override string ToString() {
                return value1 + " " + value2;
            }

        }

        public class ListDoubleData {
            public List<T1> value1;
            public List<T2> value2;

            public ListDoubleData(List<T1> v1, List<T2> v2) {
                value1 = v1;
                value2 = v2;
            }

            public override string ToString() {
                string r = "";

                for (int i=0; i<value1.Count; i++) {
                    r += value1[i] + " " + value2[i] + "\n";
                }

                return r;
            }
        }
        


        public List<T1> value1s = new List<T1>();
        public List<T2> value2s = new List<T2>();

        public DoubleDataList(List<T1> value1s = null, List<T2> values2s = null) {
            if (value1s != null && values2s != null) {
                this.value1s = value1s;
                this.value2s = values2s;
            }
        }

        public void AddItem(T1 value1, T2 value2) {
            if (value1 != null && value2 != null) {
                value1s.Add(value1);
                value2s.Add(value2);
            }
        }

        public bool RemoveItem(int index) {
            if (index < value1s.Count && index < value2s.Count) {
                if (value1s[index] != null && value2s[index] != null) {
                    value1s.RemoveAt(index);
                    value2s.RemoveAt(index);
                    return true;
                }
            }

            return false;
        }

        public void AddItems(List<T1> value1, List<T2> value2) {
            if (value1 != null && value2 != null) {
                value1s.AddRange(value1);
                value2s.AddRange(value2);
            }
        }

        public DoubleData GetItem(int index) {
            if (index < value1s.Count && index < value2s.Count) {
                if (value1s[index] != null && value2s[index] != null) {
                    
                    DoubleData data = new DoubleData(value1s[index], value2s[index]);
                    return data;
                }
            }

            return null;
        }

        public ListDoubleData GetItems() {
            
            return new ListDoubleData(value1s, value2s);
            
        }

        public override string ToString() {
            return GetItems().ToString();
        }
           

    }

    

}

namespace MCCLIB {

    class MCC {
        public static string Info() {
            return "MCC Info function at " + DateTime.Now + "\n Usage: \n First import MCC.commands that is the main namespace. Then use some of the classes inside of that namespace like: Calculator \n Check repository for documentation";
        }

        public static string Help() {
            string repoLink = "https://github.com/Moo-Cow-News/MCCLIB";
            
            return repoLink;
        }

    }
}
