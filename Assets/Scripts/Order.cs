using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{
    // Order class
    // Holds all possible recipes and Coffee names
    public enum CoffeeName 
    {
        Black,
        BlackChocolate,
        StrongBlack,
        StrongBlackChocolate,
        White,
        WhiteChocolate,
        StrongWhite,
        StrongWhiteChocolate,
        Tea,
        ChocolateTea,
        StrongTea,
        StrongChocolateTea,
        WhiteTea,
        ChocolateWhiteTea,
        StrongWhiteTea,
        StrongChocolateWhiteTea,
    }

    public static Dictionary<CoffeeName, List<Item>> possibleOrders;

    public static Dictionary<CoffeeName, List<Item>> easyOrders;
    public static Dictionary<CoffeeName, List<Item>> mediumOrders;
    public static Dictionary<CoffeeName, List<Item>> hardOrders;

    //public static List<Dictionary<CoffeeName, List<Item>>> allOrders;

    public static Dictionary<DifficultyController.Difficulty, Dictionary<CoffeeName, List<Item>>> allOrders;

    static Order()
    {
        possibleOrders = new Dictionary<CoffeeName, List<Item>>();
        
        easyOrders = new Dictionary<CoffeeName, List<Item>>();
        mediumOrders = new Dictionary<CoffeeName, List<Item>>();
        hardOrders = new Dictionary<CoffeeName, List<Item>>();

        allOrders = new Dictionary<DifficultyController.Difficulty, Dictionary<CoffeeName, List<Item>>>();

        // Easy Orders
        easyOrders.Add(CoffeeName.Black, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        easyOrders.Add(CoffeeName.White, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            }
        });

        easyOrders.Add(CoffeeName.Tea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        easyOrders.Add(CoffeeName.WhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            }
        });

        // Medium Orders
        mediumOrders.Add(CoffeeName.BlackChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        mediumOrders.Add(CoffeeName.WhiteChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        mediumOrders.Add(CoffeeName.ChocolateTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        mediumOrders.Add(CoffeeName.ChocolateWhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        // Hard Orders
        hardOrders.Add(CoffeeName.StrongBlack, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongBlackChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongWhite, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongWhiteChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongChocolateTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongWhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            }
        });

        hardOrders.Add(CoffeeName.StrongChocolateWhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 2
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Milk,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Chocolate,
                amount = 1
            }
        });

        
        // Create Order Dictionary sorted by Difficulty
        
        allOrders.Add(DifficultyController.Difficulty.Easy, easyOrders);
        allOrders.Add(DifficultyController.Difficulty.Medium, mediumOrders);
        allOrders.Add(DifficultyController.Difficulty.Hard, hardOrders);
    }
}
