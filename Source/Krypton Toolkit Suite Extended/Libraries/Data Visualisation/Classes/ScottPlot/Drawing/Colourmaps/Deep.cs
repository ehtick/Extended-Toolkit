﻿namespace Krypton.Toolkit.Suite.Extended.Data.Visualisation
{
    public class Deep : IColourmap
    {
        public (byte r, byte g, byte b) GetRGB(byte value) =>
            (cmaplocal[value, 0], cmaplocal[value, 1], cmaplocal[value, 2]);

        private static readonly byte[,] cmaplocal = {
            { 253, 254, 204 },
            { 251, 253, 203 },
            { 249, 252, 202 },
            { 247, 251, 200 },
            { 245, 250, 199 },
            { 243, 250, 198 },
            { 241, 249, 197 },
            { 239, 248, 196 },
            { 237, 247, 195 },
            { 235, 247, 193 },
            { 233, 246, 192 },
            { 231, 245, 191 },
            { 229, 244, 190 },
            { 227, 244, 189 },
            { 225, 243, 188 },
            { 223, 242, 187 },
            { 221, 242, 186 },
            { 219, 241, 185 },
            { 217, 240, 184 },
            { 215, 239, 183 },
            { 212, 239, 182 },
            { 210, 238, 181 },
            { 208, 237, 180 },
            { 206, 236, 179 },
            { 204, 236, 179 },
            { 202, 235, 178 },
            { 200, 234, 177 },
            { 198, 234, 176 },
            { 196, 233, 175 },
            { 193, 232, 175 },
            { 191, 231, 174 },
            { 189, 231, 173 },
            { 187, 230, 172 },
            { 185, 229, 172 },
            { 183, 229, 171 },
            { 181, 228, 170 },
            { 178, 227, 170 },
            { 176, 226, 169 },
            { 174, 226, 169 },
            { 172, 225, 168 },
            { 170, 224, 168 },
            { 167, 224, 167 },
            { 165, 223, 167 },
            { 163, 222, 166 },
            { 161, 221, 166 },
            { 159, 221, 165 },
            { 156, 220, 165 },
            { 154, 219, 165 },
            { 152, 218, 164 },
            { 150, 218, 164 },
            { 148, 217, 164 },
            { 146, 216, 164 },
            { 144, 215, 164 },
            { 141, 215, 163 },
            { 139, 214, 163 },
            { 137, 213, 163 },
            { 135, 212, 163 },
            { 133, 211, 163 },
            { 131, 211, 163 },
            { 129, 210, 163 },
            { 127, 209, 163 },
            { 125, 208, 163 },
            { 124, 207, 163 },
            { 122, 206, 163 },
            { 120, 206, 163 },
            { 118, 205, 163 },
            { 117, 204, 163 },
            { 115, 203, 163 },
            { 113, 202, 163 },
            { 112, 201, 163 },
            { 110, 200, 163 },
            { 109, 199, 163 },
            { 107, 198, 163 },
            { 106, 197, 164 },
            { 105, 196, 164 },
            { 103, 195, 164 },
            { 102, 194, 164 },
            { 101, 194, 164 },
            { 100, 193, 164 },
            { 99, 192, 164 },
            { 98, 191, 164 },
            { 97, 190, 164 },
            { 96, 189, 164 },
            { 95, 188, 164 },
            { 94, 187, 164 },
            { 93, 186, 164 },
            { 92, 185, 164 },
            { 91, 184, 164 },
            { 90, 183, 164 },
            { 90, 182, 164 },
            { 89, 180, 164 },
            { 88, 179, 164 },
            { 88, 178, 164 },
            { 87, 177, 164 },
            { 86, 176, 164 },
            { 86, 175, 164 },
            { 85, 174, 163 },
            { 85, 173, 163 },
            { 84, 172, 163 },
            { 83, 171, 163 },
            { 83, 170, 163 },
            { 82, 169, 163 },
            { 82, 168, 163 },
            { 81, 167, 163 },
            { 81, 166, 162 },
            { 81, 165, 162 },
            { 80, 164, 162 },
            { 80, 163, 162 },
            { 79, 162, 162 },
            { 79, 161, 162 },
            { 79, 160, 162 },
            { 78, 159, 161 },
            { 78, 158, 161 },
            { 77, 157, 161 },
            { 77, 156, 161 },
            { 77, 155, 161 },
            { 76, 154, 160 },
            { 76, 153, 160 },
            { 75, 152, 160 },
            { 75, 151, 160 },
            { 75, 150, 160 },
            { 74, 149, 159 },
            { 74, 148, 159 },
            { 74, 147, 159 },
            { 73, 146, 159 },
            { 73, 145, 158 },
            { 73, 144, 158 },
            { 72, 143, 158 },
            { 72, 142, 158 },
            { 72, 141, 157 },
            { 71, 140, 157 },
            { 71, 139, 157 },
            { 71, 138, 157 },
            { 70, 137, 157 },
            { 70, 136, 156 },
            { 70, 135, 156 },
            { 69, 134, 156 },
            { 69, 133, 156 },
            { 69, 132, 155 },
            { 68, 131, 155 },
            { 68, 130, 155 },
            { 68, 129, 155 },
            { 68, 128, 155 },
            { 67, 127, 154 },
            { 67, 126, 154 },
            { 67, 125, 154 },
            { 66, 124, 154 },
            { 66, 123, 153 },
            { 66, 122, 153 },
            { 66, 121, 153 },
            { 65, 120, 153 },
            { 65, 119, 153 },
            { 65, 118, 152 },
            { 64, 117, 152 },
            { 64, 116, 152 },
            { 64, 115, 152 },
            { 64, 114, 152 },
            { 64, 113, 151 },
            { 63, 112, 151 },
            { 63, 111, 151 },
            { 63, 110, 151 },
            { 63, 109, 151 },
            { 63, 108, 150 },
            { 62, 107, 150 },
            { 62, 106, 150 },
            { 62, 105, 150 },
            { 62, 104, 150 },
            { 62, 103, 149 },
            { 62, 102, 149 },
            { 62, 101, 149 },
            { 62, 100, 149 },
            { 62, 99, 148 },
            { 62, 98, 148 },
            { 62, 97, 148 },
            { 62, 96, 148 },
            { 62, 95, 147 },
            { 62, 94, 147 },
            { 62, 92, 147 },
            { 62, 91, 147 },
            { 62, 90, 146 },
            { 62, 89, 146 },
            { 62, 88, 146 },
            { 62, 87, 145 },
            { 62, 86, 145 },
            { 63, 85, 144 },
            { 63, 84, 144 },
            { 63, 83, 143 },
            { 63, 82, 143 },
            { 63, 80, 142 },
            { 64, 79, 141 },
            { 64, 78, 141 },
            { 64, 77, 140 },
            { 64, 76, 139 },
            { 65, 75, 138 },
            { 65, 74, 137 },
            { 65, 73, 136 },
            { 65, 72, 135 },
            { 65, 71, 133 },
            { 65, 70, 132 },
            { 65, 69, 131 },
            { 65, 68, 129 },
            { 66, 67, 128 },
            { 65, 66, 126 },
            { 65, 65, 125 },
            { 65, 64, 123 },
            { 65, 64, 122 },
            { 65, 63, 120 },
            { 65, 62, 118 },
            { 65, 61, 117 },
            { 64, 60, 115 },
            { 64, 60, 113 },
            { 64, 59, 112 },
            { 64, 58, 110 },
            { 63, 57, 108 },
            { 63, 56, 107 },
            { 63, 56, 105 },
            { 62, 55, 103 },
            { 62, 54, 102 },
            { 61, 53, 100 },
            { 61, 53, 98 },
            { 61, 52, 97 },
            { 60, 51, 95 },
            { 60, 50, 93 },
            { 59, 50, 92 },
            { 59, 49, 90 },
            { 58, 48, 88 },
            { 58, 48, 87 },
            { 57, 47, 85 },
            { 57, 46, 84 },
            { 56, 45, 82 },
            { 56, 45, 81 },
            { 55, 44, 79 },
            { 54, 43, 77 },
            { 54, 42, 76 },
            { 53, 42, 74 },
            { 53, 41, 73 },
            { 52, 40, 71 },
            { 52, 40, 70 },
            { 51, 39, 68 },
            { 50, 38, 67 },
            { 50, 37, 65 },
            { 49, 37, 64 },
            { 48, 36, 62 },
            { 48, 35, 61 },
            { 47, 34, 59 },
            { 47, 34, 58 },
            { 46, 33, 57 },
            { 45, 32, 55 },
            { 45, 31, 54 },
            { 44, 31, 52 },
            { 43, 30, 51 },
            { 43, 29, 50 },
            { 42, 28, 48 },
            { 41, 28, 47 },
            { 40, 27, 45 },
            { 40, 26, 44 }

        };
    }
}