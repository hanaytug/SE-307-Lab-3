using System;
using System.Collections.Generic;

namespace SE_307_Lab_3
{
    public class HardwareTest
    {
        public void HardwareTestScenario()
        {
            List<Hardware> hardwares = new List<Hardware>();

            hardwares = CreateDummyData(5);
            
            Hardware mainObject = new Hardware();

            while (true)
            {
                mainObject.DisplayMenu();
                int choice = mainObject.ChoiceScanner();
                String component;

                switch (choice)
                {
                    case 1: 
                        // Search for a hardware
                        Console.Write("Please enter a hardware component : ");
                        component = Console.ReadLine();
                        mainObject.SearchProduct(hardwares, component);
                        break;
                    case 2:
                        // Print every category which has product
                        mainObject.FindAvailableComponents(hardwares);
                        break;
                    case 3:
                        // Edit Hardware
                        Console.Write("Please enter a hardware component : ");
                        component = Console.ReadLine();
                        mainObject.EditProduct(component, hardwares);
                        break;
                }
            }
            
            
        }

        private List<Hardware> CreateDummyData(int count)
        {
            List<Hardware> hardwares = new List<Hardware>();
            
            for (int i = 1; i <= count; i++)
            {
                Hardware temp = new Hardware("RAM", "Product_no" + i);
                Hardware temp2 = new Hardware("CPU", "Product_no" + i);
                Hardware temp3 = new Hardware("Motherboard", "Product_no" + i);
                Hardware temp4 = new Hardware("Case", "Product_no" + i);
                Hardware temp5 = new Hardware("Power Supply", "Product_no" + i);
                Hardware temp6 = new Hardware("Optical Drives", "Product_no" + i);
                Hardware temp7 = new Hardware("GPU", "Product_no" + i);
                Hardware temp8 = new Hardware("Accessories", "Product_no" + i);
                
                hardwares.Add(temp);
                hardwares.Add(temp2);
                hardwares.Add(temp3);
                hardwares.Add(temp4);
                hardwares.Add(temp5);
                hardwares.Add(temp6);
                hardwares.Add(temp7);
                hardwares.Add(temp8);
            }

            return hardwares;
        }
    }
}