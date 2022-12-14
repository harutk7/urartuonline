using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BonusMarket.Admin.Models;
using BonusMarket.Shared.DbProvider;
using BonusMarket.Shared.Models.Core;
using BonusMarket.Shared.Models.Core.Auth;
using BonusMarket.Shared.Models.Core.Permission;
using BonusMarket.Shared.Models.Core.User;
using BonusMarket.Shared.Services;

namespace BonusMarket.Admin.Utils
{
    public class ContextInitializer
    {
        public static void Initialize(Context context, EncryptionService encryptionService)
        {
            // context.Database.EnsureCreated();
//            context.Database.Migrate();

            // init permissions
            if (!context.Permissions.Any())
            {
                context.Permissions.Add(new Permission()
                {
                    ModuleNumber = (int)Modules.Auth,
                    ModuleName = "AuthModule.Login",
                    PermissionName = "AuthLogin",
                    Description = "Permissions are only for Developers",
                    PermissionNumber = (int)AuthModule.Login,
                });
                context.Permissions.Add(new Permission()
                {
                    ModuleNumber = (int)Modules.Admin,
                    ModuleName = "AdminModule.Index",
                    PermissionName = "AdminIndex",
                    Description = "Permissions are only for Developers",
                    PermissionNumber = (int)AdminModule.Index,
                });

                context.SaveChanges();
            }
            
            // init roles
            if (!context.Roles.Any())
            {
                context.Roles.Add(new Role()
                {
                    Name = "Default",
                    SystemName = "Default",
                    Active = true,
                    CreationDate = DateTime.Now,
                    Description = "Default Role",
                    SystemRole = true
                });
                context.Roles.Add(new Role()
                {
                    Name = "Admin",
                    SystemName = "Admin",
                    Active = true,
                    CreationDate = DateTime.Now,
                    Description = "Admin Role",
                    SystemRole = true
                });


                context.SaveChanges();
            }
            
            // init role permissions
            if (!context.RolePermissions.Any())
            {
                var currentPermission = context.Permissions.Where(r => r.PermissionName == "AuthLogin").ToList()[0];
                var currentRole = context.Roles.Where(r => r.SystemName == "Default").ToList()[0];

                context.RolePermissions.Add(new RolePermission()
                {
                    Role = currentRole,
                    Permission = currentPermission,
                });
                
                currentPermission = context.Permissions.Where(r => r.PermissionName == "AdminIndex").ToList()[0];
                currentRole = context.Roles.Where(r => r.SystemName == "Default").ToList()[0];

                context.RolePermissions.Add(new RolePermission()
                {
                    Role = currentRole,
                    Permission = currentPermission,
                });

                context.SaveChanges();
            }

            if (!context.Users.Where(r => r.Email == "admin@urartuonline.am").Any())
            {
                string password = "urartu321";
                // string salt = encryptionService.HashedSaltGenerator();
                // string hashedPassword = encryptionService.CryptPasswordWithSalt(password: password, HashedSalt: salt);
                string hashedPassword = encryptionService.CalculateMD5Hash(password);
                
                context.Users.Add(new User()
                {
                    Email = "admin@urartuonline.am",
                    CreationDate = DateTime.Now,
                    FirstName = "System",
                    LastName = "System Adminyan Useri",
                    Phone = "+37",
                    Address = "Vaspurakan 8",
                    PasswordHash = hashedPassword,
                    Role = UserRoleEnum.ROLE_GUEST
                });

                context.SaveChanges();
            }

            if (!context.UserRoles.Any())
            {
                var currentUser = context.Users.Where(r => r.Email == "admin@urartuonline.am").ToList()[0];
                var currentRole = context.Roles.Where(r => r.SystemName == "Default").ToList()[0];
                context.UserRoles.Add(new UserRole()
                {
                    User = currentUser,
                    Role = currentRole
                });
                currentRole = context.Roles.Where(r => r.SystemName == "Admin").ToList()[0];
                context.UserRoles.Add(new UserRole()
                {
                    User = currentUser,
                    Role = currentRole
                });
                context.SaveChanges();
            }
            
            return;
//            
//            if (context.Books.Any() || context.Authors.Any() || context.Categories.Any())
//                return;
//
//
//            // Adding Top level categories
//            context.Categories.Add(
//                new Category
//                {
//                    Level = 0,
//                    BannerImage = "",
//                    Key = "root"
//                }
//            );
//
//            context.SaveChanges();
//
//            // Adding level 1 categories
//            context.Categories.AddRange(
//                new Category[]
//                {
//                    new Category
//                    {
//                        Level = 1,
//                        BannerImage = "",
//                        Key = "classic",
//                        ParentCategory = context.Categories.Where(c => c.Key == "root").First()
//                    },
//                    new Category
//                    {
//                        Level = 1,
//                        BannerImage = "",
//                        Key = "fantasy",
//                        ParentCategory = context.Categories.Where(c => c.Key == "root").First()
//                    },
//                    new Category
//                    {
//                        Level = 1,
//                        BannerImage = "",
//                        Key = "fiction",
//                        ParentCategory = context.Categories.Where(c => c.Key == "root").First()
//                    }
//                }
//            );
//
//            context.SaveChanges();
//
//            // Adding level 2 categories
//            context.Categories.AddRange(
//                new Category[]
//                {
//                    new Category
//                    {
//                        Level = 2,
//                        BannerImage = "",
//                        Key = "romance",
//                        ParentCategory = context.Categories.Where(c => c.Key == "fiction").First()
//                    },
//                    new Category
//                    {
//                        Level = 2,
//                        BannerImage = "",
//                        Key = "drama",
//                        ParentCategory = context.Categories.Where(c => c.Key == "classic").First()
//                    },
//                    new Category
//                    {
//                        Level = 1,
//                        BannerImage = "",
//                        Key = "fantastic",
//                        ParentCategory = context.Categories.Where(c => c.Key == "fantasy").First()
//                    }
//                }
//            );
//            context.SaveChanges();
//
//            // Adding Category translations
//            context.CategoryTranslations.AddRange(
//                new CategoryTranslation[] {
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Fantasy",
//                        Category = context.Categories.Where(c => c.Key == "fantasy").First()
//                    },
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Classic",
//                        Category = context.Categories.Where(c => c.Key == "classic").First()
//                    },
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Fiction",
//                        Category = context.Categories.Where(c => c.Key == "fiction").First()
//                    },
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Romance",
//                        Category = context.Categories.Where(c => c.Key == "romance").First()
//                    },
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Drama",
//                        Category = context.Categories.Where(c => c.Key == "drama").First()
//                    },
//                    new CategoryTranslation
//                    {
//                        Language = "en",
//                        Title = "Fantastic",
//                        Category = context.Categories.Where(c => c.Key == "fantastic").First()
//                    }
//                }
//            );
//
//            context.SaveChanges();
//
//            // Adding Books
//            context.Books.AddRange(
//                new Book[]
//                {
//                    new Book
//                    {
//                        Isbn = "9789939688107",
//                        Year = 2020,
//                        IsActive = true,
//                        IsVat = true,
//                        Price = 3400,
//                        PublicationType = "SoftCover",
//                        Size = "130x200",
//                        Weight = 350,
//                        PagesCount = 288,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939688565",
//                        Year = 2020,
//                        IsActive = true,
//                        IsVat = true,
//                        Price = 6400,
//                        PublicationType = "HardCover",
//                        Size = "170x243",
//                        Weight = 680,
//                        PagesCount = 368,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939688084",
//                        Year = 2020,
//                        IsActive = true,
//                        IsVat = false,
//                        Price = 3700,
//                        PublicationType = "HardCover",
//                        Size = "152x222",
//                        Weight = 350,
//                        PagesCount = 160,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939682044",
//                        Year = 2013,
//                        IsActive = true,
//                        IsVat = false,
//                        Price = 3200,
//                        PublicationType = "SoftCover",
//                        Size = "145x210",
//                        Weight = 305,
//                        PagesCount = 224,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939688121",
//                        Year = 2020,
//                        IsActive = true,
//                        IsVat = false,
//                        Price = 3600,
//                        PublicationType = "HardCover",
//                        Size = "129x195",
//                        Weight = 400,
//                        PagesCount = 224,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939684536",
//                        Year = 2016,
//                        ReYear = 2020,
//                        IsActive = true,
//                        IsVat = true,
//                        Price = 2800,
//                        PublicationType = "SoftCover",
//                        Size = "120x200",
//                        Weight = 260,
//                        PagesCount = 272,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939685380",
//                        Year = 2017,
//                        IsActive = true,
//                        IsVat = true,
//                        Price = 7500,
//                        PublicationType = "HardCover",
//                        Size = "220x305",
//                        Weight = 825,
//                        PagesCount = 104,
//                        Language = "Russian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939683386",
//                        Year = 2014,
//                        IsActive = true,
//                        IsVat = false,
//                        Price = 3400,
//                        PublicationType = "HardCover",
//                        Size = "245x345",
//                        Weight = 620,
//                        PagesCount = 44,
//                        Language = "Eastern Armenian"
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939685427",
//                        IsActive = true,
//                        IsVat = true,
//                        Price = 10900,
//                        PublicationType = "HardCover",
//                        Size = "200x285",
//                        Weight = 900,
//                        PagesCount = 164
//                    },
//                    new Book
//                    {
//                        Isbn = "9789939688145",
//                        IsActive = true,
//                        IsVat = false,
//                        Price = 3700,
//                        Size = "140x215",
//                        Weight = 600,
//                        PagesCount = 432
//                    }
//                }
//            );
//            context.SaveChanges();
//
//            // Adding Book Translations
//            context.BookTranslations.AddRange(
//                new BookTranslation[]
//                {
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Title = "????????????????????????",
//                        ShortDescription = "?????????? ?????????? ???? ?????????????????????????????? (1914) ???????????????????????? ???????????????????????? ???????????? ?? ?????????????? ???????????????????? ?????????????? ???????????????????? ?????????????? ???????????? ?????????????????????????? ???????????????????????????????????? ?????????????? ?????????????????? ?????????????????? ?????????? ?????????????????? ????????????????: ???????????????? ???????????????????????? ?? ????????????, ?????????? ???????? ???????? ????????, ???????????????????????????? ??????????????????, ???? ???? ?????????? ?? ???????? ???????????????????????? ??????????????????????, ??????????????????????????????, ?????????????????????????? ???? ?????????????????????? ??????????: ?????????????? ???????????????? ?????? ?????????????????? ?????? ???????????????????? ?????????? ?????? ??????????????????, ?????????? ?????????? ???????????? ???????????????? ????????????????????, ???????????? ???????????? ????, ????????, ???? ???????????????? ?????????????? ??: ???????????????????????????? ????????? ???????? ?????????????????????????? ?????????????????? ???????????????????? ???? ????????????????????????????????????????: ???????? ?? ????????, ???? ?????????????????????????????? ?????????????? ?????????????????????????????? ???????????? ?????????? ?? ?????????? ?????????????? ??????????????????` ???????????????????? ?????????????????? ?????????????????????? ????????????????????????:",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Title = "Dubliners",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688565").First(),
//                        Title = "?????????? ?????????? ????????????",
//                        ShortDescription = "2007 ???????????????? ?????????? ?????????? ?????? ???????? ???????????? ???? ???????????? ???????? ?? ???????????????????? ???? ?????? ?????????????? ??????????` ?????? ?????????? ???????????? ??????????????: ???????? ???????????????? ?????????? ???????????????????????? ???????????? ???????????????????????? ?????????????????????? ??, ?????????? ???????????? ?????????????????????? ???? ??????????????????????????: ?????????????????? ?????????????? ???????????????? ???????????? ?????? ?? ???????????? ?????????? ?????????????????? ???????????????????????????????? ???????????????? ???????? ?? ???????????? ?????????? ???????????????? ?? ???????????? ?????? ???????????????????? ????????????: ???????? ???????????? ?? ?????????? ?????? ???????????????????? ???????????????????? ???????????? ????????????????????????, ?????????????????? ???? ????????????????????????????, ?????? ?????????????????????? ???????????????????????? ?????????? ???????????????? ?????????????????????????? ?????????? ?? ?????????? ?????????????????? ??????????????????:",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688565").First(),
//                        Title = "A Thousand Splendid Suns",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688084").First(),
//                        Title = "?????????????????????????? ???? ????????????????",
//                        ShortDescription = "???????????? ?????????????? ???????????????? ?????????????? ?? ?????????????????????????? ??????????????: ???????????????????? ???? ?????????? ?????????????? ???? ????????????, ???? ?????? ?? ????????????????, ?? ?????? ?? ?????? ???????????????? ?????????? ??????????????????: ???????????????????? ???? ?????????????????????????? ???????? ?????????? ?????????????????? ?? ???????????? ???????????????? ???????????????? ?????? ???? ??????????? ?? ???????????? ??????????????????????:",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688084").First(),
//                        Title = "Comet in Moominland",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939682044").First(),
//                        Title = "???????????????????? ??????????????????",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939682044").First(),
//                        Title = "Adventures of Cipollino",
//                        ShortDescription = "What a fruitful and animated world of human like vegetables is created in Rodari???s work! Just take a look at the names of the inhabitants of that garden kingdom: Cipollino ??? the little onion, Signor Tomato, Prince Lemon which speaks of the traits and habits of their bearers. The real and fictive worlds interweave and poignant and acute humor fills the pages which doesn???t prevent the author from addressing the gravest problems including tolerance and peace between different strata of society.",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688121").First(),
//                        Title = "???????????? ???????????? ???????? ??????????",
//                        ShortDescription = "?????? ???????????????? ???????? ?????????????? ???????????? ?????????? ???????????????????????? ?? ?????????? ?????????????? ?? ???????????????????????? ??????????????????????????????, ???????????? ?????? ?????????????????? ?????? ?????? ???????????? ???????????? ?? ?????? ?????????? ?????????? ???????????? ???????????????? ?????????????????????????? ?????? ??????????????????????????????????, ???????????? ????????????, ?????????? ???????????????? ????????????????????????, ?????????? ?????????? ???? ???????? ???????????????? ?????????????????????? ?????????????????????????????? ?????????? ???????????????????? ?? ?????? ?????????????? ???????????????? ???????? ?????????????????????????? ?????? ?????????????? ????????????????",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688121").First(),
//                        Title = "How To Think Like Steve Jobs",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939684536").First(),
//                        Title = "?????????????????? ????????????",
//                        ShortDescription = "???????? ?????????????????? ?? ???????????????? ???????????????????? ?????? ?????????????? ?????????? ????????????, ?????? ???????????? ?????????? ???????????? ???????????????? ???????? ??????????, ????????????, ???????????????? ?????????????????????????????????? ???? ???????????? ?????????????????????????? ??????????????????????????????????????, ?????? ?????????????? ???????????? ?????? ?????? ???????????????????????? ?????????????????????????? ??????????????????????????????????: ???????????????????? ?????????????????????? ??????????, ???????? ?????????? ?????? ?????????????? ??????????, ?????????????????????? ?? ?????????????????? ?????????? ??????, ?????? ???????????? ???????????????? ??, ???? ???????????? ?????????????? ?? ???????????? ?????? ?????? ?????????????? ?????? ??????. ???????????????????????? ???????????? ???? ?????????? ?????? ?????????????????? ???? ??????????????????: ?? ?????????? ?????????? ?????????????????? ??, ???? ???????????????????? ???????? ?? ?????????????????????? ???? ???? ?????????? ?????? ???? ???????????? ???????????? ????????????, ?????? ???????????????? ???? ?????????? ??????????????????????????????????????:",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939684536").First(),
//                        Title = "The Painted Veil",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939685380").First(),
//                        Title = "10 ?????? ???????????????? ????????????????????",
//                        ShortDescription = "???????????? ?????????????????????? ???????? ?????? ???????????????? ?????????????????????? ?????????????? ???? ???????????? ????????????????????????????: ?????????????? ???? ?????????????? ??????????????????, ?????????? ?????????? ???????????? ???????????? ???????????????????? ???? ???? ?????????? ????????????????????????????????, ???????? ?????????? ???????? ???? ?????????? ?????? ?????? ???????????????????? ??????: ???????? ???????????? ?????????????????? ?? ???????????????????????????????? ????????????: ?????????????? ?????????????????? ?????????????????????? ???????????????? ?????????????????????? ?????????? ?????????????????????? ???????????????? ?????????????????????? ??????????, ?????????????????????????? ???????????????? ???????? ?????????? ???? ???????????????? ?????????????????????? ???? ????????????????????????????????????????????:",
//                        Language = "????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939685380").First(),
//                        Title = "10 Outstanding Armenian Queens",
//                        Language = "Russian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939683386").First(),
//                        Title = "???????????? ??????????",
//                        ShortDescription = "???????????? ???????????? ???????????????? ?? ??????????????????` ???????? ???? ???????????????? ???????????????? ??????????????????????: ?? ??????????, ???? ?????????????? ?? ???????????? ????????????: ?????? ????????????, ????????????, ???????????????? ???????????????? ?? ?????????? ????????????: ???????????? ?????????????? ?????????????? ?????????????? ?? ???????? ?????? ???????????????????? ???????? ?????????????????? ??????????????: ????????????????????????, ?????????????? ?????????????????? ?? ???????? ????????????????, ?? ?????????????? ?????? ???????????? ???? ?????????????????",
//                        Language = "??????????????????????????",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939683386").First(),
//                        Title = "Oliver Twist",
//                        ShortDescription = "Oliver Twist is an orphan. He is nine years old and works as an apprentice for a funeral director. But life is hard and Oliver decides to run away to London. When he reaches the capital, he meets a young pickpocket who works for a villain called Fagin. Oliver falls into Fagin's clutches and is taught to steal from the rich...",
//                        Language = "Eastern Armenian",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939685427").First(),
//                        Title = "??????????. ???????????????????????? ????????",
//                        ShortDescription = "????????????. ???????????????????????? ???????????? ???????????????????????? ?? ?????????????????????? ???? ?????????? ???? ?????????????? ?????????????????????? ???? ???????????????? ????????????????, ???????? ?????????????????? ???? ??????????????????, ???????????????? ???? ??????????????????????????, ???????????? ???? ???????????? ??????????????????????, ???????? ???????????????? ???????????? ???????????? ??????????????: ?????????????????? ???????????? ?????????????????? ???? ?????????? ???????????????????? ???????????? ?????????????? ????????????????????????????????????, ???????????? ???? ???????????????? ???? ???????????? ???????????????? ???????????????????????? ???? ?????????????????????? ?????????????????? ???? ?????????????????? ?????????????? ?????????????? ???? ?????????????? ??????????????, ?????????????? ???? ?????????????????? ???????????????????????? ?????????????? ???????????? ?????????? ???????????????? ???????????????? ???? ??????????????????, ??????????????? ???? ???? ????????????, ???????????? ?????????????????????? ?????????? ?????????????? ????????????, ?????? ???????????????? ?????????? ?????????????????? ???? ?????????????????? ???????????????????????????????? ????: ???????? ??????????????????????, ???????????? ???? ?????????? ???????????????????????????????? ???????????????????????? ?????????????? ???????????????????? ?????? ???? ?????? ???????????? ???????????????????? ?????? ?????????? ?????????????? ???????????????? ?????????????????????? ???????????? ??????????, ?????? ???????????????????????????? ???????????????? ???????????????????????????? ?????? ???????? ?????????????????????????? ???????????????????? ????????????:",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939685427").First(),
//                        Title = "Yerevan Sketchbook",
//                        ShortDescription = "???Yerevan Sketchbook??? introduces the capital city with not only its rich history and sites worth seeing, but also with its hues and scents, its noise and music, its famous and not so famous residents and simply with its daily and vibrant life. Artists Ararat Minasyan and Zack Demirtshyan, alternating between whimsical momentary impressions and profound ideological expressions, depict scenes of the rich past and the lively present of this locale, situated in the crossroads of the East and the West. The city is presented either in vibrant colors or in black and white, but is always lovely for the residents, and full of interesting and unexpected discoveries for its guests. With light outlines and sometimes with heavy brushstrokes, these sketches will make the images of the old and new Yerevan more familiar to Armenians. As for visitors, this book will make their trip to Yerevan a trip to remember.",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688145").First(),
//                        Title = "?????????? ????????????????: ???????????????? ???????????????????? ??????????????????",
//                        ShortDescription = "???????????? ?????????????????? ???????? ?????????????????? ?????????????? ???????????? ???????????? ?????????????????????? ???????? ??: ???????? ?????????????? ???????????? ?????????? ??. ?????????????? ???? ??????, ???????? ???????? ?????????????? ???????????????? ???????????????????? ??????????????????, ???????????????? ?? ?????????? ?????????????? ??????????????????: ?????????????? ???? ?????????? ?????????????????? ?????????????????? ?????????????????? ???? ???????????????? ???????????????????? ???? ??????????????????????: ???????????? ???????????????? ???????????????????????????????????? ?????????? ?????????? ???? ???????????????????????? ?? ???? ???????????????????????? ???????????? ??????????????, ???????? ?????? ?? ???????????? ?????????????? ???????????? ?????? ?????????????????????? ?? ?????????? ??????????????????????????????:",
//                        IsActive = true
//                    },
//                    new BookTranslation
//                    {
//                        Book = context.Books.Where(b => b.Isbn == "9789939688145").First(),
//                        Title = "Nobody's boy",
//                        IsActive = true
//                    }
//                }
//            );
//            context.SaveChanges();
//
//
//            // Adding authors
//            context.Authors.AddRange(
//                new Author[]
//                {
//                    new Author
//                    {
//                        Title = "?????????? ????????",
//                        Key = "jamesjoyce"
//                    },
//                    new Author
//                    {
//                        Title = "???????? ????????????????",
//                        Key = "aramarsenyan"
//                    },
//                    new Author
//                    {
//                        Title = "?????????? ??????????????????????????",
//                        Key = "artemharutyunyan"
//                    },
//                    new Author
//                    {
//                        Title = "???????????? ??????????????????????????",
//                        Key = "gayaneharutyunyan"
//                    }
//                }
//            );
//            context.SaveChanges();
//
//
//            // Adding Book Authors
//            context.BookAuthors.AddRange(
//                new BookAuthor[]
//                {
//                    new BookAuthor
//                    {
//                        Author = context.Authors.Where(a => a.Key == "jamesjoyce").First(),
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Role = "Author"
//                    },
//                    new BookAuthor
//                    {
//                        Author = context.Authors.Where(a => a.Key == "aramarsenyan").First(),
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Role = "Translator"
//                    },
//                    new BookAuthor
//                    {
//                        Author = context.Authors.Where(a => a.Key == "artemharutyunyan").First(),
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Role = "Translator"
//                    },
//                    new BookAuthor
//                    {
//                        Author = context.Authors.Where(a => a.Key == "gayaneharutyunyan").First(),
//                        Book = context.Books.Where(b => b.Isbn == "9789939688107").First(),
//                        Role = "Translator"
//                    }
//                }
//            );


            // ??????????????? To continue from here
        }
    }
}