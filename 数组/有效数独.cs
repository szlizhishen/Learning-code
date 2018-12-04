public class Solution {
    public bool IsValidSudoku(char[,] board) {
        for(int i=0; i<9; i++){
                int[] row = new int[9];
                int[] col = new int[9];
                int[] cube = new int[9];
//使用行列宫的三个数组对其进行flag查验重复
                for (int j=0; j<9; j++){
                    if(board[i,j]!='.'){
                        if(row[board[i,j] - '1'] ==1){
                            return false;
                        }else {
                            row[board[i,j] - '1'] =1;
                        }
                    }
                    if(board[j,i] != '.'){
                        if(col[board[j,i] - '1'] == 1){
                            return false;
                        }else{
                            col[board[j,i] - '1'] = 1;
                        }
                    }
                    //每一宫内行列的变换
                    int cubeX = 3 * (i/3) + j/3;
                    int cubeY = 3 * (i%3) + j%3;
                    if(board[cubeX,cubeY]!='.'){
                        if  (cube[board[cubeX,cubeY] - '1'] == 1){
                            return false;
                        }else{
                            cube[board[cubeX,cubeY] - '1'] = 1;
                        }
                    }
                }
            }
            return true;
    }
}