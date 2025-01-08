namespace csharp_fundamentals_lists.Main
{
    public class Core
    {
        private List<string> _iceCreams = new List<string>()
        {
            "Strawberry Cheesecake",
            "Chocolate Fudge Brownie",
            "Cookie Dough",
            "Strawberry Cheesecake",
            "Caramel Chew Chew"
        };

        public Core()
        {
            
        }

        public List<string> Question1()
        {
            _iceCreams.Add("Phish Food");
            _iceCreams.Add("Peanut Butter Cup");

            return _iceCreams;        
        }

        public int Question2()
        {
            return _iceCreams.Count;
        }
        
        public List<string> Question3()
        {
            List<string> results = _iceCreams.Concat(this.MoreIceCream).Concat(this.EvenMoreIceCream).ToList();
            
            return results;
        }
        
        public List<string> Question4()
        {
            List<string> results = _iceCreams.Concat(this.MoreIceCream).Concat(this.EvenMoreIceCream).Distinct().ToList();
            
            return results;
        }

        public List<string> MoreIceCream = new List<string>()
        {
                "Minter Wonderland Ice Cream",
                "Half Baked",
                "Chocolate Fudge Brownie",
                "Baked Alaska",
                "Strawberry Cheesecake"
        };
        
        public List<string> EvenMoreIceCream = new List<string>()
        {
                "Praline",
                "Cookie Dough",
                "Strawberry Cheesecake",
                "Vanilla"
        };
    }
}
