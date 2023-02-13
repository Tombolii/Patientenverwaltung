using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MySql.Data.MySqlClient;
using Moq;
using Patientenverwaltung;
using Patientenverwaltung.Model;


namespace PatientverwaltungTest
{
    public class DataReaderMapperTest
    {

        DataReaderMapper underTest = new DataReaderMapper();

        [Test]
        public void Test1()
        {
            // given
            int expectedIdPatient = 1;
            Mock<> reader = new Mock<MySqlDataReader>();
            reader.SetupGet(x => x.GetInt32("idPatient")).Returns(expectedIdPatient);

            //when
            List<Patient> result = underTest.extractPatientenFromReader(reader.Object);
            Assert.Equals(expectedIdPatient, result[0].idPatient);
        }
    }
}
