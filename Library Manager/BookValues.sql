INSERT Libraries.Book(TitleID, LibraryID, Quantity)
SELECT T.TitleID, L.LibraryID, Q.Quantity
FROM Libraries.Title T
	CROSS JOIN Libraries.[Library] L
	CROSS APPLY
	(
		VALUES(T.TitleID * L.LibraryID % 5)
	) Q (Quantity)
	WHERE Q.Quantity > 0