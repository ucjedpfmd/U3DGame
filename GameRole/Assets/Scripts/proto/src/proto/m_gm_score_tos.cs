namespace proto {
	public class m_gm_score_tos : Message
	{
		public int id = 0;
		public int fraction = 0;
		public m_gm_score_tos() {
		}
		public override string getMethodName() {
			return "gm_score";
		}
		public override string getClassName() {
			return "m_gm_score_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"fraction", "int", "null"}};
		}
	}
}
