function countVowelStrings(n: number): number {
    if (n===1) return 5;
    let values: number[] = [1,1,1,1,1]; 
    for (let k=2; k<=n; k++) {       
        for (let i=1; i<5; i++) {
            values[i] += values[i-1]
        }
    }
    
    let ret = 0;
    for (let e of values) {
        ret += e;
    }
        
    return ret;
};