﻿Begin
    INSERT INTO [dbo].[tblMovie] ([Id], [Title], [Description], [Cost], [RatingId], [FormatId], [DirectorId], [InStkQty], [ImagePath])
    VALUES
        (1, 'Movie 1', 'Description 1', 12.99, 1, 1, 1, 10, 'movie1.jpg'),
        (2, 'Movie 2', 'Description 2', 9.99, 2, 2, 2, 5, 'movie2.jpg'),
        (3, 'Movie 3', 'Description 3', 14.99, 3, 3, 3, 15, 'movie3.jpg');
End