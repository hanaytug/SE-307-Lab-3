using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;

namespace SE_307_Lab_3
{
    public class Hardware
    {
        private String _productCategory;
        public string ProductCategory { get => _productCategory; set => _productCategory = value; }

        private String _productNo;
        public string ProductNo { get => _productNo; set => _productNo = value; }

        public Hardware()
        {
            ProductCategory = "undefined";
            ProductNo = "undefined";
        }
        
        public Hardware(String productCategory, String productNo)
        {
            ProductCategory = productCategory;
            ProductNo = productNo;
        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("********************** Menu **********************");
            Console.WriteLine("1 - ) Search for a hardware component");
            Console.WriteLine("2 - ) Get hardware component list.");
            Console.WriteLine("3 - ) Edit hardware component.");
            Console.WriteLine("-1 - ) Exit.");
            Console.WriteLine("**************************************************");
        }

        public void FindAvailableComponents(List<Hardware> hardwares)
        {
            // TODO find available component
            Console.WriteLine("Following hardware components are available : RAM, CPU, Motherboard, Case, Power Supply, Optical Drives, GPU, Accessories");
        }

        public void SearchProduct(List<Hardware> hardwares, String productCategory)
        {
            if (productCategory.Equals("RAM", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("CPU", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Motherboard", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Case", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Power Supply", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Optical Drives", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("GPU", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Accessories", StringComparison.InvariantCultureIgnoreCase) ||
                productCategory.Equals("Other", StringComparison.InvariantCultureIgnoreCase)
            )
            {
                int tempCount = 0;

                Console.Write(productCategory + " has following products : ");

                foreach (Hardware hardware in hardwares)
                {
                    if (hardware.ProductCategory.Equals(productCategory, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.Write(hardware.ProductNo + ", ");
                        tempCount++;
                    }
                }

                if (tempCount == 0)
                {
                    Console.Write(productCategory + " has no products.");
                }
            }
            else
            {
                Console.WriteLine("Category : " + productCategory + " doesn't exists.");
            }
            
        }

        public List<Hardware> EditProduct(String productCategory,List<Hardware> hardwares)
        {
            while (true)
            {
                if (productCategory.Equals("RAM", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("CPU", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Motherboard", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Case", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Power Supply", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Optical Drives", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("GPU", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Accessories", StringComparison.InvariantCultureIgnoreCase) ||
                    productCategory.Equals("Other", StringComparison.InvariantCultureIgnoreCase)
                )
                {
                    Console.WriteLine("Do you want to add or remove product (1 to add, 2 to remove) :");
                    int choice = EditScanner();

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please input name of the product :");
                            String tempNo = Console.ReadLine();
                            Hardware tempHardware = new Hardware(productCategory, tempNo);
                            hardwares.Add(tempHardware);
                            return hardwares;
                        case 2: 
                            Console.WriteLine("Specify product position :");
                            int tempPosition = numberScanner();

                            if (tempPosition <= FindCategorySize(productCategory, hardwares))
                            {
                                hardwares.RemoveAt(tempPosition);
                                Console.WriteLine("Successfully removed.");
                                return hardwares;
                            }
                            else
                            {
                                Console.WriteLine("Error : size exceed.");
                            }
                            break;
                    }
                } else
                {
                    Console.WriteLine("Category : " + productCategory + " doesn't exists.");
                    Console.Write("Please enter a hardware component : ");
                    productCategory = Console.ReadLine();
                }
            }
        }

        public int FindCategorySize(String productCategory, List<Hardware> hardwares)
        {
            int size = 0;
            
            foreach (Hardware hardware in hardwares)
            {
                if (hardware.ProductCategory.Equals(productCategory, StringComparison.InvariantCultureIgnoreCase))
                {
                    size++;
                }
            }
            
            return size;
        }

        public int ChoiceScanner()
        {
            bool loop = true;
            int choice = 0;
            
            while(loop)
            {
                Console.WriteLine("Please enter your choice (1, 2, 3 or -1) :");
                
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("You can only enter number");
                }
                else
                {
                    if (choice > 3 || choice < -1 || choice == 0)
                    {
                        Console.WriteLine("You can only enter 1,2,3 or -1");
                        continue;
                    }

                    if (choice == -1)
                    {
                        Environment.Exit(1);
                    }
                    
                    loop = false;
                    
                }
                
            }
            
            return choice;
        }

        public int numberScanner()
        {
            bool loop = true;
            int choice = 0;
            
            while(loop)
            {
                
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("You can only enter number");
                }
                else
                {
                    loop = false;
                }
                
            }
            
            return choice;
        }
        
        public int EditScanner()
        {
            bool loop = true;
            int choice = 0;
            
            while(loop)
            {
                
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("You can only enter number");
                }
                else
                {
                    if (choice > 3 || choice < -1 || choice == 0)
                    {
                        Console.WriteLine("You can only enter 1,2");
                        continue;
                    }

                    loop = false;
                    
                }
                
            }
            
            return choice;
        }
    }
}