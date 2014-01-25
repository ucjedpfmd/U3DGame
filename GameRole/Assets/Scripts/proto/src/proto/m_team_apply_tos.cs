namespace proto {
	public class m_team_apply_tos : Message
	{
		public int op_type = 0;
		public double teamer_id = 0;
		public double apply_id = 0;
		public m_team_apply_tos() {
		}
		public override string getMethodName() {
			return "team_apply";
		}
		public override string getClassName() {
			return "m_team_apply_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"teamer_id", "double", "null"},new string[] {"apply_id", "double", "null"}};
		}
	}
}
