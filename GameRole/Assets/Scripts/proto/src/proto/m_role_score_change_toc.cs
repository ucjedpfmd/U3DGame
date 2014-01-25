namespace proto {
	public class m_role_score_change_toc : Message
	{
		public object[] role_scores;
		public m_role_score_change_toc() {
		}
		public override string getMethodName() {
			return "role_score_change";
		}
		public override string getClassName() {
			return "m_role_score_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_scores", "array", "p_role_score"}};
		}
	}
}
