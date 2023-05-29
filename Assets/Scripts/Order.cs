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
    
    
    static Order()
    {
        possibleOrders = new Dictionary<CoffeeName, List<Item>>();
        possibleOrders.Add(CoffeeName.Black, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        possibleOrders.Add(CoffeeName.BlackChocolate, new List<Item>() {
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
        

        possibleOrders.Add(CoffeeName.White, new List<Item>() {
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

        possibleOrders.Add(CoffeeName.WhiteChocolate, new List<Item>() {
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
        
        possibleOrders.Add(CoffeeName.Tea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        possibleOrders.Add(CoffeeName.ChocolateTea, new List<Item>() {
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

        possibleOrders.Add(CoffeeName.WhiteTea, new List<Item>() {
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

        possibleOrders.Add(CoffeeName.ChocolateWhiteTea, new List<Item>() {
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
        
        possibleOrders.Add(CoffeeName.StrongBlack, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        possibleOrders.Add(CoffeeName.StrongBlackChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
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

        possibleOrders.Add(CoffeeName.StrongWhite, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
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

        possibleOrders.Add(CoffeeName.StrongWhiteChocolate, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Coffee,
                amount = 1
            },
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

        possibleOrders.Add(CoffeeName.StrongTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
            new Item() {
                itemType = Item.ItemType.Water,
                amount = 1
            }
        });

        possibleOrders.Add(CoffeeName.StrongChocolateTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
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

        possibleOrders.Add(CoffeeName.StrongWhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
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

        possibleOrders.Add(CoffeeName.StrongChocolateWhiteTea, new List<Item>() {
            new Item() {
                itemType = Item.ItemType.Tea,
                amount = 1
            },
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

    }
}
