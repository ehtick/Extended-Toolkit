﻿namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation
{
    public class Balance : IColourmap
    {
        public (byte r, byte g, byte b) GetRGB(byte value) =>
            (cmaplocal[value, 0], cmaplocal[value, 1], cmaplocal[value, 2]);

        private static readonly byte[,] cmaplocal = {
            { 24, 28, 67 },
            { 25, 30, 70 },
            { 26, 31, 73 },
            { 27, 33, 76 },
            { 28, 34, 79 },
            { 29, 35, 82 },
            { 30, 37, 85 },
            { 31, 38, 88 },
            { 32, 39, 91 },
            { 33, 41, 95 },
            { 33, 42, 98 },
            { 34, 43, 101 },
            { 35, 45, 105 },
            { 36, 46, 108 },
            { 37, 47, 111 },
            { 37, 48, 115 },
            { 38, 50, 118 },
            { 39, 51, 122 },
            { 39, 52, 125 },
            { 40, 54, 129 },
            { 40, 55, 132 },
            { 41, 56, 136 },
            { 41, 58, 140 },
            { 41, 59, 143 },
            { 41, 60, 147 },
            { 41, 62, 151 },
            { 41, 63, 154 },
            { 41, 64, 158 },
            { 41, 66, 162 },
            { 40, 67, 165 },
            { 39, 69, 169 },
            { 38, 71, 172 },
            { 37, 72, 176 },
            { 35, 74, 179 },
            { 33, 76, 182 },
            { 31, 78, 184 },
            { 28, 80, 186 },
            { 25, 82, 188 },
            { 22, 85, 189 },
            { 19, 87, 190 },
            { 16, 89, 190 },
            { 13, 91, 190 },
            { 12, 94, 190 },
            { 10, 96, 190 },
            { 10, 98, 190 },
            { 10, 100, 190 },
            { 11, 102, 189 },
            { 13, 104, 189 },
            { 15, 106, 189 },
            { 17, 108, 188 },
            { 19, 110, 188 },
            { 22, 112, 188 },
            { 25, 114, 187 },
            { 27, 116, 187 },
            { 30, 118, 187 },
            { 33, 120, 187 },
            { 35, 122, 186 },
            { 38, 123, 186 },
            { 41, 125, 186 },
            { 43, 127, 186 },
            { 46, 129, 186 },
            { 48, 131, 186 },
            { 51, 132, 186 },
            { 54, 134, 186 },
            { 56, 136, 186 },
            { 59, 137, 186 },
            { 62, 139, 186 },
            { 64, 141, 186 },
            { 67, 143, 186 },
            { 70, 144, 186 },
            { 72, 146, 186 },
            { 75, 148, 186 },
            { 78, 149, 186 },
            { 81, 151, 186 },
            { 83, 153, 186 },
            { 86, 154, 187 },
            { 89, 156, 187 },
            { 92, 157, 187 },
            { 95, 159, 187 },
            { 98, 160, 187 },
            { 101, 162, 188 },
            { 104, 164, 188 },
            { 107, 165, 188 },
            { 110, 167, 189 },
            { 113, 168, 189 },
            { 117, 170, 190 },
            { 120, 171, 190 },
            { 123, 172, 191 },
            { 126, 174, 191 },
            { 129, 175, 192 },
            { 133, 177, 192 },
            { 136, 178, 193 },
            { 139, 180, 194 },
            { 142, 181, 195 },
            { 145, 183, 195 },
            { 148, 184, 196 },
            { 152, 186, 197 },
            { 155, 187, 198 },
            { 158, 188, 199 },
            { 161, 190, 200 },
            { 164, 191, 201 },
            { 167, 193, 202 },
            { 170, 194, 203 },
            { 173, 196, 204 },
            { 176, 197, 205 },
            { 179, 199, 206 },
            { 182, 201, 207 },
            { 185, 202, 208 },
            { 188, 204, 210 },
            { 191, 205, 211 },
            { 193, 207, 212 },
            { 196, 208, 213 },
            { 199, 210, 215 },
            { 202, 212, 216 },
            { 205, 213, 217 },
            { 208, 215, 218 },
            { 211, 217, 220 },
            { 213, 218, 221 },
            { 216, 220, 222 },
            { 219, 222, 224 },
            { 222, 224, 225 },
            { 225, 225, 227 },
            { 227, 227, 228 },
            { 230, 229, 230 },
            { 233, 231, 231 },
            { 235, 233, 233 },
            { 238, 234, 234 },
            { 241, 236, 236 },
            { 241, 236, 235 },
            { 240, 234, 233 },
            { 239, 232, 230 },
            { 238, 229, 227 },
            { 237, 227, 224 },
            { 236, 224, 222 },
            { 235, 222, 219 },
            { 234, 220, 216 },
            { 233, 217, 213 },
            { 232, 215, 210 },
            { 231, 213, 207 },
            { 230, 210, 205 },
            { 229, 208, 202 },
            { 229, 206, 199 },
            { 228, 203, 196 },
            { 227, 201, 193 },
            { 226, 199, 190 },
            { 225, 196, 187 },
            { 225, 194, 184 },
            { 224, 192, 181 },
            { 223, 189, 178 },
            { 223, 187, 176 },
            { 222, 185, 173 },
            { 221, 182, 170 },
            { 220, 180, 167 },
            { 220, 178, 164 },
            { 219, 175, 161 },
            { 218, 173, 158 },
            { 218, 171, 155 },
            { 217, 169, 152 },
            { 216, 166, 150 },
            { 216, 164, 147 },
            { 215, 162, 144 },
            { 214, 159, 141 },
            { 214, 157, 138 },
            { 213, 155, 135 },
            { 212, 153, 132 },
            { 211, 150, 129 },
            { 211, 148, 127 },
            { 210, 146, 124 },
            { 209, 143, 121 },
            { 209, 141, 118 },
            { 208, 139, 115 },
            { 207, 137, 112 },
            { 207, 134, 110 },
            { 206, 132, 107 },
            { 205, 130, 104 },
            { 205, 127, 101 },
            { 204, 125, 99 },
            { 203, 123, 96 },
            { 202, 121, 93 },
            { 202, 118, 91 },
            { 201, 116, 88 },
            { 200, 114, 85 },
            { 199, 111, 83 },
            { 199, 109, 80 },
            { 198, 107, 77 },
            { 197, 104, 75 },
            { 196, 102, 72 },
            { 195, 99, 70 },
            { 195, 97, 67 },
            { 194, 95, 65 },
            { 193, 92, 63 },
            { 192, 90, 60 },
            { 191, 87, 58 },
            { 190, 85, 56 },
            { 190, 82, 54 },
            { 189, 80, 52 },
            { 188, 77, 50 },
            { 187, 75, 48 },
            { 186, 72, 46 },
            { 185, 69, 44 },
            { 184, 67, 43 },
            { 183, 64, 41 },
            { 182, 61, 40 },
            { 180, 59, 39 },
            { 179, 56, 38 },
            { 178, 53, 37 },
            { 177, 51, 37 },
            { 175, 48, 36 },
            { 174, 46, 36 },
            { 172, 43, 36 },
            { 171, 41, 36 },
            { 169, 38, 36 },
            { 167, 36, 36 },
            { 165, 33, 37 },
            { 163, 31, 37 },
            { 161, 29, 37 },
            { 159, 27, 38 },
            { 157, 25, 38 },
            { 155, 23, 39 },
            { 153, 22, 39 },
            { 151, 20, 40 },
            { 148, 19, 40 },
            { 146, 18, 40 },
            { 144, 16, 41 },
            { 141, 16, 41 },
            { 139, 15, 41 },
            { 136, 15, 41 },
            { 134, 14, 41 },
            { 131, 14, 41 },
            { 128, 14, 41 },
            { 126, 14, 41 },
            { 123, 14, 41 },
            { 120, 14, 40 },
            { 118, 14, 40 },
            { 115, 14, 39 },
            { 112, 14, 39 },
            { 109, 14, 38 },
            { 107, 15, 37 },
            { 104, 15, 37 },
            { 101, 15, 36 },
            { 99, 14, 35 },
            { 96, 14, 34 },
            { 94, 14, 33 },
            { 91, 14, 32 },
            { 88, 14, 31 },
            { 86, 14, 30 },
            { 83, 13, 29 },
            { 81, 13, 28 },
            { 78, 13, 27 },
            { 75, 12, 25 },
            { 73, 12, 24 },
            { 70, 11, 23 },
            { 68, 11, 22 },
            { 65, 10, 20 },
            { 63, 10, 19 },
            { 60, 9, 18 }

        };
    }
}