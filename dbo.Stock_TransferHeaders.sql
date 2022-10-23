CREATE TABLE [dbo].[Stock_TransferHeaders] (
    [TransferHeaderID]                INT            IDENTITY (1, 1) NOT NULL,
    [Date]                            DATETIME2 (7)  NOT NULL,
    [Transfer_Type]                     NVARCHAR(MAX)            NOT NULL,
    [Name]                            NVARCHAR (MAX) NOT NULL,
    [Stock_TransferBodyTansferBodyID] INT            NULL,
    [Transfer_Type]                   NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Stock_TransferHeaders] PRIMARY KEY CLUSTERED ([TransferHeaderID] ASC),
    CONSTRAINT [FK_Stock_TransferHeaders_Stock_TransferBodies_Stock_TransferBodyTansferBodyID] FOREIGN KEY ([Stock_TransferBodyTansferBodyID]) REFERENCES [dbo].[Stock_TransferBodies] ([TansferBodyID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Stock_TransferHeaders_Stock_TransferBodyTansferBodyID]
    ON [dbo].[Stock_TransferHeaders]([Stock_TransferBodyTansferBodyID] ASC);

