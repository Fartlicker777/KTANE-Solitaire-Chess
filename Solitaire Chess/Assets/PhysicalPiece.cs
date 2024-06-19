using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalPiece : MonoBehaviour {

   public enum PieceType { Knight, Bishop, Rook, Queen, King };
   public PieceType Piece;

   public Sprite[] PieceSpr;
   public SpriteRenderer PieceRen;

   public PhysicalPiece (PieceType Piece) {
      this.Piece = Piece;
   }

   public void InstantiatePiece () {
      PieceRen.sprite = PieceSpr[(int) Piece];
   }

}
