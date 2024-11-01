using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Practic5.Tests
{
    public class Vector3Tests
    {
        [Fact]
        public void VectorSum()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);
            Vector3 V2 = new Vector3(6, 1, 2);

            // Act
            Vector3 V3 = V1 + V2;

            // Assert
            Assert.Equal(9, V3.X);
            Assert.Equal(5, V3.Y);
            Assert.Equal(7, V3.Z);
        }
        [Fact]
        public void VectorVery()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);
            Vector3 V2 = new Vector3(6, 1, 2);

            // Act
            Vector3 V3 = V1 - V2;

            // Assert
            Assert.Equal(-3, V3.X);
            Assert.Equal(3, V3.Y);
            Assert.Equal(3, V3.Z);
        }
        [Fact]
        public void VectorMultiplicationToScalar()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);
            double k = 3;

            // Act
            Vector3 V3 = V1 * k;

            // Assert
            Assert.Equal(9, V3.X);
            Assert.Equal(12, V3.Y);
            Assert.Equal(15, V3.Z);
        }
        [Fact]
        public void VectoScalarMultiplication()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);
            Vector3 V2 = new Vector3(6, 1, 2);
            double k = 0;

            // Act
            k = V1 * V2;

            // Assert
            Assert.Equal(32, k);
        }
        [Fact]
        public void VectorCross()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);
            Vector3 V2 = new Vector3(6, 1, 2);

            // Act
            Vector3 V3 = V1.Cross(V2);

            // Assert
            Assert.Equal(3, V3.X);
            Assert.Equal(24, V3.Y);
            Assert.Equal(-21, V3.Z);
        }
        [Fact]
        public void VectorLenght()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);

            // Act
            double l = V1.Lenght();

            // Assert
            Assert.Equal(7.0710678118654755, l);
        }
        [Fact]
        public void VectorNormalize()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);

            // Act
            Vector3 V2 = V1.Normalize();

            // Assert
            Assert.Equal(0.42426406871192851, V2.X);
            Assert.Equal(0.56568542494923801, V2.Y);
            Assert.Equal(0.70710678118654746, V2.Z);
        }
        [Fact]
        public void VectorToString()
        {
            // Arrange
            Vector3 V1 = new Vector3(3, 4, 5);

            // Act
            string vector = V1.ToString();

            // Assert
            Assert.Equal("(3, 4, 5)", vector);
        }
    }
}
