def to_rna(dna_strand):
    dict = {ord('G'): ord('C'), ord('C'): ord('G'), ord('T'): ord('A'), ord('A'): ord('U')}
    return dna_strand.translate(dict)