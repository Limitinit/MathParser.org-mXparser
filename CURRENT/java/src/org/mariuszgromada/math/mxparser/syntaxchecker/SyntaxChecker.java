/* SyntaxChecker.java */
/* Generated By:JavaCC: Do not edit this line. SyntaxChecker.java */
package org.mariuszgromada.math.mxparser.syntaxchecker;

public final class SyntaxChecker implements SyntaxCheckerConstants {

  public final void checkSyntax() throws ParseException, TokenMgrError
  {
    start();
  }

  final public void start() throws ParseException {
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case INTEGER:
    case LEFT_PAR:
    case PLUS:
    case MINUS:
    case UNIT:
    case NOT:
    case BITNOT:
    case REAL:
    case IDENTIFIER:
    case FUNCTION:
    case 44:{
      expression();
      jj_consume_token(0);
      break;
      }
    case 0:{
      jj_consume_token(0);
      break;
      }
    default:
      jj_la1[0] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
    }
  }

  final public void expression() throws ParseException {
    booleanExpression();
  }

  final public void booleanExpression() throws ParseException {
    equalExpression();
    label_1:
    while (true) {
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case OR:
      case AND:
      case IMP:
      case CIMP:
      case NIMP:
      case CNIMP:
      case NAND:
      case EQV:
      case NOR:
      case BIT:
      case XOR:{
        ;
        break;
        }
      default:
        jj_la1[1] = jj_gen;
        break label_1;
      }
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case OR:{
        jj_consume_token(OR);
        equalExpression();
        break;
        }
      case AND:{
        jj_consume_token(AND);
        equalExpression();
        break;
        }
      case NOR:{
        jj_consume_token(NOR);
        equalExpression();
        break;
        }
      case NAND:{
        jj_consume_token(NAND);
        equalExpression();
        break;
        }
      case XOR:{
        jj_consume_token(XOR);
        equalExpression();
        break;
        }
      case IMP:{
        jj_consume_token(IMP);
        equalExpression();
        break;
        }
      case CIMP:{
        jj_consume_token(CIMP);
        equalExpression();
        break;
        }
      case NIMP:{
        jj_consume_token(NIMP);
        equalExpression();
        break;
        }
      case CNIMP:{
        jj_consume_token(CNIMP);
        equalExpression();
        break;
        }
      case EQV:{
        jj_consume_token(EQV);
        equalExpression();
        break;
        }
      case BIT:{
        jj_consume_token(BIT);
        equalExpression();
        break;
        }
      default:
        jj_la1[2] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
    }
  }

  final public void equalExpression() throws ParseException {
    relationalExpression();
    label_2:
    while (true) {
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case EQ:
      case NEQ:
      case LT:
      case LEQ:
      case GT:
      case GEQ:{
        ;
        break;
        }
      default:
        jj_la1[3] = jj_gen;
        break label_2;
      }
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case EQ:{
        jj_consume_token(EQ);
        relationalExpression();
        break;
        }
      case NEQ:{
        jj_consume_token(NEQ);
        relationalExpression();
        break;
        }
      case GT:{
        jj_consume_token(GT);
        relationalExpression();
        break;
        }
      case GEQ:{
        jj_consume_token(GEQ);
        relationalExpression();
        break;
        }
      case LT:{
        jj_consume_token(LT);
        relationalExpression();
        break;
        }
      case LEQ:{
        jj_consume_token(LEQ);
        relationalExpression();
        break;
        }
      default:
        jj_la1[4] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
    }
  }

  final public void relationalExpression() throws ParseException {
    additiveExpression();
  }

  final public void additiveExpression() throws ParseException {
    multiplicativeExpression();
    label_3:
    while (true) {
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case PLUS:
      case MINUS:{
        ;
        break;
        }
      default:
        jj_la1[5] = jj_gen;
        break label_3;
      }
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case PLUS:{
        jj_consume_token(PLUS);
        multiplicativeExpression();
        break;
        }
      case MINUS:{
        jj_consume_token(MINUS);
        multiplicativeExpression();
        break;
        }
      default:
        jj_la1[6] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
    }
  }

  final public void multiplicativeExpression() throws ParseException {
    unaryExpression();
    label_4:
    while (true) {
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case MULTIPLY:
      case DIV:
      case POWER:
      case MODULO:{
        ;
        break;
        }
      default:
        jj_la1[7] = jj_gen;
        break label_4;
      }
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case POWER:{
        jj_consume_token(POWER);
        unaryExpression();
        break;
        }
      case MULTIPLY:{
        jj_consume_token(MULTIPLY);
        unaryExpression();
        break;
        }
      case DIV:{
        jj_consume_token(DIV);
        unaryExpression();
        break;
        }
      case MODULO:{
        jj_consume_token(MODULO);
        unaryExpression();
        break;
        }
      default:
        jj_la1[8] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
    }
  }

  final public void unaryExpression() throws ParseException {
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case NOT:
    case BITNOT:{
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case NOT:{
        jj_consume_token(NOT);
        break;
        }
      case BITNOT:{
        jj_consume_token(BITNOT);
        break;
        }
      default:
        jj_la1[9] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
      break;
      }
    default:
      jj_la1[10] = jj_gen;
      ;
    }
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case PLUS:
    case MINUS:{
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case PLUS:{
        jj_consume_token(PLUS);
        break;
        }
      case MINUS:{
        jj_consume_token(MINUS);
        break;
        }
      default:
        jj_la1[11] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
      break;
      }
    default:
      jj_la1[12] = jj_gen;
      ;
    }
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case INTEGER:
    case REAL:{
      realConstant();
      break;
      }
    case UNIT:
    case IDENTIFIER:
    case FUNCTION:
    case 44:{
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case UNIT:
      case IDENTIFIER:
      case 44:{
        identifier();
        break;
        }
      case FUNCTION:{
        jj_consume_token(FUNCTION);
        break;
        }
      default:
        jj_la1[13] = jj_gen;
        jj_consume_token(-1);
        throw new ParseException();
      }
      switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
      case LEFT_PAR:{
        jj_consume_token(LEFT_PAR);
        argumentList();
        jj_consume_token(RIGHT_PAR);
        break;
        }
      default:
        jj_la1[14] = jj_gen;
        ;
      }
      break;
      }
    case LEFT_PAR:{
      jj_consume_token(LEFT_PAR);
      expression();
      jj_consume_token(RIGHT_PAR);
      break;
      }
    default:
      jj_la1[15] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
    }
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case FACTORIAL:{
      jj_consume_token(FACTORIAL);
      break;
      }
    default:
      jj_la1[16] = jj_gen;
      ;
    }
  }

  final public void argumentList() throws ParseException {
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case INTEGER:
    case LEFT_PAR:
    case PLUS:
    case MINUS:
    case UNIT:
    case NOT:
    case BITNOT:
    case REAL:
    case IDENTIFIER:
    case FUNCTION:
    case 44:{
      expression();
      label_5:
      while (true) {
        switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
        case COMMA:
        case SEMICOLON:{
          ;
          break;
          }
        default:
          jj_la1[17] = jj_gen;
          break label_5;
        }
        switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
        case COMMA:{
          jj_consume_token(COMMA);
          break;
          }
        case SEMICOLON:{
          jj_consume_token(SEMICOLON);
          break;
          }
        default:
          jj_la1[18] = jj_gen;
          jj_consume_token(-1);
          throw new ParseException();
        }
        expression();
      }
      break;
      }
    default:
      jj_la1[19] = jj_gen;
      ;
    }
  }

  final public void identifier() throws ParseException {
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case IDENTIFIER:{
      jj_consume_token(IDENTIFIER);
      break;
      }
    case UNIT:{
      jj_consume_token(UNIT);
      break;
      }
    case 44:{
      jj_consume_token(44);
      label_6:
      while (true) {
        switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
        case CHAR:{
          jj_consume_token(CHAR);
          break;
          }
        case IDENTIFIER:{
          jj_consume_token(IDENTIFIER);
          label_7:
          while (true) {
            switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
            case LEFT_PAR:
            case RIGHT_PAR:
            case PLUS:
            case MINUS:
            case MULTIPLY:
            case DIV:
            case POWER:
            case MODULO:
            case COMMA:
            case LT:
            case GT:
            case OR:
            case AND:
            case NOT:
            case REAL:{
              ;
              break;
              }
            default:
              jj_la1[20] = jj_gen;
              break label_7;
            }
            switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
            case NOT:{
              jj_consume_token(NOT);
              break;
              }
            case MODULO:{
              jj_consume_token(MODULO);
              break;
              }
            case POWER:{
              jj_consume_token(POWER);
              break;
              }
            case AND:{
              jj_consume_token(AND);
              break;
              }
            case MULTIPLY:{
              jj_consume_token(MULTIPLY);
              break;
              }
            case DIV:{
              jj_consume_token(DIV);
              break;
              }
            case LEFT_PAR:{
              jj_consume_token(LEFT_PAR);
              break;
              }
            case RIGHT_PAR:{
              jj_consume_token(RIGHT_PAR);
              break;
              }
            case MINUS:{
              jj_consume_token(MINUS);
              break;
              }
            case PLUS:{
              jj_consume_token(PLUS);
              break;
              }
            case COMMA:{
              jj_consume_token(COMMA);
              break;
              }
            case OR:{
              jj_consume_token(OR);
              break;
              }
            case GT:{
              jj_consume_token(GT);
              break;
              }
            case LT:{
              jj_consume_token(LT);
              break;
              }
            case REAL:{
              jj_consume_token(REAL);
              break;
              }
            default:
              jj_la1[21] = jj_gen;
              jj_consume_token(-1);
              throw new ParseException();
            }
          }
          break;
          }
        default:
          jj_la1[22] = jj_gen;
          jj_consume_token(-1);
          throw new ParseException();
        }
        switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
        case CHAR:
        case IDENTIFIER:{
          ;
          break;
          }
        default:
          jj_la1[23] = jj_gen;
          break label_6;
        }
      }
      jj_consume_token(45);
      break;
      }
    default:
      jj_la1[24] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
    }
  }

  final public void realConstant() throws ParseException {
    switch ((jj_ntk==-1)?jj_ntk_f():jj_ntk) {
    case REAL:{
      jj_consume_token(REAL);
      break;
      }
    case INTEGER:{
      jj_consume_token(INTEGER);
      break;
      }
    default:
      jj_la1[25] = jj_gen;
      jj_consume_token(-1);
      throw new ParseException();
    }
  }

  /** Generated Token Manager. */
  public SyntaxCheckerTokenManager token_source;
  SimpleCharStream jj_input_stream;
  /** Current token. */
  public Token token;
  /** Next token. */
  public Token jj_nt;
  private int jj_ntk;
  private int jj_gen;
  final private int[] jj_la1 = new int[26];
  static private int[] jj_la1_0;
  static private int[] jj_la1_1;
  static {
      jj_la1_init_0();
      jj_la1_init_1();
   }
   private static void jj_la1_init_0() {
      jj_la1_0 = new int[] {0x60201b01,0x98000000,0x98000000,0x7d00000,0x7d00000,0x1800,0x1800,0x1e000,0x1e000,0x60000000,0x60000000,0x1800,0x1800,0x200000,0x200,0x200300,0x20000,0xc0000,0xc0000,0x60201b00,0x3a85fe00,0x3a85fe00,0x0,0x0,0x200000,0x100,};
   }
   private static void jj_la1_init_1() {
      jj_la1_1 = new int[] {0x1e00,0xff,0xff,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x1c00,0x0,0x1e00,0x0,0x0,0x0,0x1e00,0x200,0x200,0x500,0x500,0x1400,0x200,};
   }

  /** Constructor with InputStream. */
  public SyntaxChecker(java.io.InputStream stream) {
     this(stream, null);
  }
  /** Constructor with InputStream and supplied encoding */
  public SyntaxChecker(java.io.InputStream stream, String encoding) {
    try { jj_input_stream = new SimpleCharStream(stream, encoding, 1, 1); } catch(java.io.UnsupportedEncodingException e) { throw new RuntimeException(e); }
    token_source = new SyntaxCheckerTokenManager(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  /** Reinitialise. */
  public void ReInit(java.io.InputStream stream) {
     ReInit(stream, null);
  }
  /** Reinitialise. */
  public void ReInit(java.io.InputStream stream, String encoding) {
    try { jj_input_stream.ReInit(stream, encoding, 1, 1); } catch(java.io.UnsupportedEncodingException e) { throw new RuntimeException(e); }
    token_source.ReInit(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  /** Constructor. */
  public SyntaxChecker(java.io.Reader stream) {
    jj_input_stream = new SimpleCharStream(stream, 1, 1);
    token_source = new SyntaxCheckerTokenManager(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  /** Reinitialise. */
  public void ReInit(java.io.Reader stream) {
    jj_input_stream.ReInit(stream, 1, 1);
    token_source.ReInit(jj_input_stream);
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  /** Constructor with generated Token Manager. */
  public SyntaxChecker(SyntaxCheckerTokenManager tm) {
    token_source = tm;
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  /** Reinitialise. */
  public void ReInit(SyntaxCheckerTokenManager tm) {
    token_source = tm;
    token = new Token();
    jj_ntk = -1;
    jj_gen = 0;
    for (int i = 0; i < 26; i++) jj_la1[i] = -1;
  }

  private Token jj_consume_token(int kind) throws ParseException {
    Token oldToken;
    if ((oldToken = token).next != null) token = token.next;
    else token = token.next = token_source.getNextToken();
    jj_ntk = -1;
    if (token.kind == kind) {
      jj_gen++;
      return token;
    }
    token = oldToken;
    jj_kind = kind;
    throw generateParseException();
  }


/** Get the next Token. */
  final public Token getNextToken() {
    if (token.next != null) token = token.next;
    else token = token.next = token_source.getNextToken();
    jj_ntk = -1;
    jj_gen++;
    return token;
  }

/** Get the specific Token. */
  final public Token getToken(int index) {
    Token t = token;
    for (int i = 0; i < index; i++) {
      if (t.next != null) t = t.next;
      else t = t.next = token_source.getNextToken();
    }
    return t;
  }

  private int jj_ntk_f() {
    if ((jj_nt=token.next) == null)
      return (jj_ntk = (token.next=token_source.getNextToken()).kind);
    else
      return (jj_ntk = jj_nt.kind);
  }

  private java.util.List<int[]> jj_expentries = new java.util.ArrayList<int[]>();
  private int[] jj_expentry;
  private int jj_kind = -1;

  /** Generate ParseException. */
  public ParseException generateParseException() {
    jj_expentries.clear();
    boolean[] la1tokens = new boolean[48];
    if (jj_kind >= 0) {
      la1tokens[jj_kind] = true;
      jj_kind = -1;
    }
    for (int i = 0; i < 26; i++) {
      if (jj_la1[i] == jj_gen) {
        for (int j = 0; j < 32; j++) {
          if ((jj_la1_0[i] & (1<<j)) != 0) {
            la1tokens[j] = true;
          }
          if ((jj_la1_1[i] & (1<<j)) != 0) {
            la1tokens[32+j] = true;
          }
        }
      }
    }
    for (int i = 0; i < 48; i++) {
      if (la1tokens[i]) {
        jj_expentry = new int[1];
        jj_expentry[0] = i;
        jj_expentries.add(jj_expentry);
      }
    }
    int[][] exptokseq = new int[jj_expentries.size()][];
    for (int i = 0; i < jj_expentries.size(); i++) {
      exptokseq[i] = jj_expentries.get(i);
    }
    return new ParseException(token, exptokseq, tokenImage);
  }

  /** Enable tracing. */
  final public void enable_tracing() {
  }

  /** Disable tracing. */
  final public void disable_tracing() {
  }

}
