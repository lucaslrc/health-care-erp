using System;
using HealthCareERP.Entities;

namespace HealthCareERP.Rules
{
    public interface IStorage
    {
        bool VerifyDataBaseServer();

        bool VerifyDataBaseExists();

        Medicine FindMedicine(string Register);

        Storage FindStorage(string LoteID);

        void ApplyMigration();

        void MigrateAnvisaSheet();

        void Init();
    }
}