using System;
using System.Collections.Generic;
namespace Cs_Playground.DesignPattern
{
    public class Clothes
    {
        private String _clothesType;
        private String _clothesColor;
        private String _clothesGender;

        public string ClothesType { get => _clothesType; set => _clothesType = value; }
        public string ClothesColor { get => _clothesColor; set => _clothesColor = value; }
        public string ClothesGender { get => _clothesGender; set => _clothesGender = value; }

        public Clothes(String clothesType, String clothesColor, String clothesGender)
        {
            this._clothesType = clothesType;
            this._clothesColor = clothesColor;
            this._clothesGender = clothesGender;
        }
    }

    public interface ClothesCriterion{
        List<Clothes> chooseClothes(List<Clothes> clothes);
    }

    public class MaleClothesCriterion : ClothesCriterion
    {
        public List<Clothes> chooseClothes(List<Clothes> clothesList)
        {
            List<Clothes> newClotheList = new List<Clothes>();
            foreach(Clothes clothes in clothesList) {
                if( clothes.ClothesGender == "male") {
                    newClotheList.Add(clothes);
                }
            }
            return newClotheList;
        }
    }

    public class ToppingClothesCriterion : ClothesCriterion
    {
        public List<Clothes> chooseClothes(List<Clothes> clothesList)
        {
            List<Clothes> newClotheList = new List<Clothes>();
            foreach (Clothes clothes in clothesList)
            {
                if (clothes.ClothesType == "topping")
                {
                    newClotheList.Add(clothes);
                }
            }
            return newClotheList;
        }
    }

    public class AndCriterion : ClothesCriterion {
        private ClothesCriterion _firstCriterion;
        private ClothesCriterion _secondCritetion;

        public AndCriterion(ClothesCriterion firstCriterion, ClothesCriterion secondCriterion) {
            _firstCriterion = firstCriterion;
            _secondCritetion = secondCriterion;
        }

        public List<Clothes> chooseClothes(List<Clothes> clothes)
        {
            List<Clothes> firstClothes = _firstCriterion.chooseClothes(clothes);
            return _secondCritetion.chooseClothes(firstClothes);
        }
    }
}
