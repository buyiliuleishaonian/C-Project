using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTHModels
{
    /// <summary>
    /// 用来封装RecipeParam
    /// </summary>
    public class RecipeInfo
    {
        //需要有RecipeName
        public string RecipeInfoName { get; set; }
       //需要有RecipeParam集合
       public List<RecipeParam> RecipeParamList { get; set; }=new   List<RecipeParam>();
    }
}
