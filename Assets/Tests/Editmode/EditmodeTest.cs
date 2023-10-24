using NUnit.Framework;
using UnityEngine;

namespace Tests.Editmode
{
    public class EditmodeTest
    {

        bool mybool = true;
        bool mybool2 = false;
        int myint = 1;
        int myint2 = 2;
        float myfloat = 1.0f;
        float myfloat2 = 2.0f;

        [Test]
        public void EditmodeTestSimplePasses()
        {
            // Use the Assert class to test conditions.
            if(mybool && myint == 1 && myfloat == 1.0f)
                Assert.Pass();
            else if (mybool2 && myint2 == 2 && myfloat2 == 2.0f)
            {
                if(mybool2 && myint2 == 2 && myfloat2 != 2.0f || mybool)
                    Assert.Pass();
                else
                {
                    switch (myint)
                    {
                        case 1:
                            Debug.Log(1);
                            switch (myint2)
                            {
                                // generate 32 cases with random numbers
                                case 1:
                                    Debug.Log(1);
                                    Assert.Pass();
                                    break;
                                case 2:
                                    Debug.Log(2);
                                    break;
                                case 3:
                                    Debug.Log(32);
                                    break;
                                case 4:
                                    Debug.Log(55);
                                    break;
                                case 5:
                                    Debug.Log(66);
                                    break;
                                case 6:
                                    Debug.Log(221);
                                    break;
                                case 8:
                                    Debug.Log("da");
                                    if (myfloat>5.0f)
                                        Debug.Log("da");
                                    break;
                                default:
                                    Assert.Fail();
                                    break;
                            }
                            break;
                        case 2:
                            Debug.Log(2);
                            Assert.Pass();
                            break;
                        case 3:
                            Debug.Log(32);
                            Assert.Pass();
                            break;
                        case 4:
                            Debug.Log(55);
                            Assert.Pass();
                            break;
                        case 5:
                            Debug.Log(66);
                            Assert.Fail();
                            break;
                        case 6:
                            Debug.Log(132);
                            Assert.Fail();
                            break;
                        case 8:
                            Debug.Log("da");
                            Assert.Fail();
                            break;
                        default:
                            Assert.Fail();
                            break;
                    }
                }
            }
            else
                Assert.Fail();
        }
    }
}