/**
 * @param {number[][]} matrix
 * @return {number[][]}
 */
var transpose = function(matrix) {
      return matrix[0].map((col, c) => matrix.map((row, r) => matrix[r][c]));

};