using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Student.Models
{
    public class IdCardBL
    {
        public IEnumerable<IdCardStructure> GetAllIds()
        {
            List<IdCardStructure> lstIdCards = new List<IdCardStructure>();
            try
            {
                lstIdCards.Add(new IdCardStructure
                {
                    intStudentID = 6345,
                    strStudentName = "Jhon",
                    strDateOfBirth = "9-11-2017",
                    lngContactNumber = 9876589768,
                    strAddress1 = "asdfasdf",
                    strAddress2 = "asdfasdf",
                    strLandMark = "asdfsadf",
                    strCity = "dsfds",
                    intPincode = 521366,
                    strPhoto = "",
                    strAlternativeName = ""
                });
            }
            catch (Exception ex)
            {

            }
            return lstIdCards;
        }       
    }
}