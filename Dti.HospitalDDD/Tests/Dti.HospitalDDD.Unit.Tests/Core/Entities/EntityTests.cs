using Dti.HospitalDDD.Unit.Tests.Core.Entities.Helpers;
using System;
using Xunit;

namespace Dti.HospitalDDD.Unit.Tests.Core.Entities
{
    public class EntityTests
    {

        [Fact]
        public void CriarEntity_DevePreencher_DeveEstaCorreta()
        {
            var id  = Guid.NewGuid();
            var dataAtual = DateTime.Now;
            var entity = new EntityHerdada(id);

            Assert.Equal(entity.Id, id);
            Assert.True(entity.DataCriacao >= dataAtual);
            Assert.False(entity.Excluido);


        }
    }
}
