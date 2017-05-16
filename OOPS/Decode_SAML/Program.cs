using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Decode_SAML
{
    class Program
    {
        static void Main(string[] args)
        {
            SAMLResponse res = new SAMLResponse();
            SAMLResponse resOld = new SAMLResponse();
            string payload = "SAMLResponse=PHNhbWxwMjpSZXNwb25zZSBEZXN0aW5hdGlvbj0iaHR0cDovL2dldGhlYWx0aC5zb2Z0b2Jpei5pbmZvL0FwcGxpY2F0aW9uRm9ybS9Ub2JhY29vVXNlciIgSUQ9IlJlc3BvbnNlSWRfNGEyNjE1YTQ0MGRmNDhjYTllZDQwYzQxODM4ZDQ5ZWYiIElzc3VlSW5zdGFudD0iMjAxNi0xMi0xN1QxMDo1NDo0NC4yNzRaIiBWZXJzaW9uPSIyLjAiIHhtbG5zOnNhbWwyPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXNzZXJ0aW9uIiB4bWxuczpzYW1scDI9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpwcm90b2NvbCI%2BPHNhbWwyOklzc3VlciBGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpuYW1laWQtZm9ybWF0OmVudGl0eSI%2BYXBwMWEuaW1wLmhlYWx0aGNhcmUuZ292PC9zYW1sMjpJc3N1ZXI%2BPGRzOlNpZ25hdHVyZSB4bWxuczpkcz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnIyI%2BPGRzOlNpZ25lZEluZm8%2BPGRzOkNhbm9uaWNhbGl6YXRpb25NZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzEwL3htbC1leGMtYzE0biMiLz48ZHM6U2lnbmF0dXJlTWV0aG9kIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI3JzYS1zaGExIi8%2BPGRzOlJlZmVyZW5jZSBVUkk9IiNSZXNwb25zZUlkXzRhMjYxNWE0NDBkZjQ4Y2E5ZWQ0MGM0MTgzOGQ0OWVmIj48ZHM6VHJhbnNmb3Jtcz48ZHM6VHJhbnNmb3JtIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI2VudmVsb3BlZC1zaWduYXR1cmUiLz48ZHM6VHJhbnNmb3JtIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMS8xMC94bWwtZXhjLWMxNG4jIi8%2BPC9kczpUcmFuc2Zvcm1zPjxkczpEaWdlc3RNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjc2hhMSIvPjxkczpEaWdlc3RWYWx1ZT44L2pyQmZGQ3lkL3p2YnA2Q1VRcm5IbndUNTA9PC9kczpEaWdlc3RWYWx1ZT48L2RzOlJlZmVyZW5jZT48L2RzOlNpZ25lZEluZm8%2BPGRzOlNpZ25hdHVyZVZhbHVlPlN0TlRDN0t2UmtJUGJ4NzVvT0FDOVpQRXdxbnJPT3YvZFlLWlZlVTJmTnlycEtybjNmeitNWnMwM3g5UndFYWIxRXdLZ3c1YlRMSVdvY1RxNkFOQVc0UzRZaGIvZUpjZkFjRVNZV2hNZHRLa3dBMmdsU0pjL2Y4N1Y2Rkw5dWRZS1I3MVg4Uzc3ampsV3BlZmJGT091QlhjYWx4b1pncVZhVDZwN0h3WGJrcWN3Q1BDVzZVaVdsdDhmdDRNQ2ZFbHpaV2FUQmNId0l3cWpCeUtjdkY3QmNiTUEvdCs0bFIxb2ZwRDk5by9FbFphZmFzQkVRTm9ZTWcvSzVzWGRsWG5tZTNkNzZ6VjBNNk8yWll4c3I4cDRzTmpFQ2wyVlZuU2wxQVRRdE9HZ2NxRFVjNEdVbUpYODlOMlJxNkx2OTlVaVNNOURPcXBzVE02SEptbmQ1T3VSZz09PC9kczpTaWduYXR1cmVWYWx1ZT48ZHM6S2V5SW5mbz48ZHM6WDUwOURhdGE%2BPGRzOlg1MDlDZXJ0aWZpY2F0ZT5NSUlGd1RDQ0JLbWdBd0lCQWdJRVVVbmZVekFOQmdrcWhraUc5dzBCQVFzRkFEQi9NUXN3Q1FZRFZRUUdFd0pWVXpFWU1CWUdBMVVFQ2hNUFZTNVRMaUJIYjNabGNtNXRaVzUwTVF3d0NnWURWUVFMRXdOSVNGTXhJakFnQmdOVkJBc1RHVU5sY25ScFptbGpZWFJwYjI0Z1FYVjBhRzl5YVhScFpYTXhKREFpQmdOVkJBTVRHMGhJVXkxR1VFdEpMVWx1ZEdWeWJXVmthV0YwWlMxRFFTMUZNVEFlRncweE5qQTJNakF4TkRNeU16aGFGdzB4T1RBMU1Ea3hOREF5TXpGYU1IZ3hDekFKQmdOVkJBWVRBbFZUTVJnd0ZnWURWUVFLRXc5VkxsTXVJRWR2ZG1WeWJtMWxiblF4RERBS0JnTlZCQXNUQTBoSVV6RU1NQW9HQTFVRUN4TURRMDFUTVJBd0RnWURWUVFMRXdkRVpYWnBZMlZ6TVNFd0h3WURWUVFERXhoaGNIQXhZUzVwYlhBdWFHVmhiSFJvWTJGeVpTNW5iM1l3Z2dFaU1BMEdDU3FHU0liM0RRRUJBUVVBQTRJQkR3QXdnZ0VLQW9JQkFRRGlPRVNYdkRDM051MVQyMEhVdktha0VNbFA1cE1ycFV6d1RLbEl1NVFsZVJ1eHU5QUZzQUpqZnovcHJqN1hjakVMcUkyZkJseExiNEV4amhUTW9tK1pCSEQxQ2tnYkV0aGJBVDNBZlh2Nk5IdzIzVzFtd0FBSGJmTkYzYzRVazBiaFhkbHFxNEZmMmdTMGVHMjQwNWY2ZHZzRm9wV1NwV1VGSHh0d1NabGkwcXBjSkRZWko2eUVqcmNBWlNoTzhXUTRJZU9aYXlZd1BPbnVhYzg1WFpLQWc1SnB4SllObkdHNEJkMURRTFhiczNPNXB2MHdJdWx3MVZTQW92Z1l4blVrRzVuSjVzVEJrMFcrajB3aC9VSjkySXdSU1VCOHdGN1hSZW5RRHg0Qzk3QTArUksyNzRwU0Y4NEpiMU1yRHV5YVFXV2lINEFxQ0l0OUloWXlpYkhsQWdNQkFBR2pnZ0pLTUlJQ1JqQU9CZ05WSFE4QkFmOEVCQU1DQmFBd0Z3WURWUjBnQkJBd0RqQU1CZ3BnaGtnQlpRTUNBUU1JTUlITEJnZ3JCZ0VGQlFjQkFRU0J2akNCdXpCU0JnZ3JCZ0VGQlFjd0FvWkdhSFIwY0RvdkwyaG9jM0JyYVdOeWJDNXRZVzVoWjJWa0xtVnVkSEoxYzNRdVkyOXRMMEZKUVM5RFpYSjBjMGx6YzNWbFpGUnZTRWhUUlc1MGNuVnpkRU5CTG5BM1l6QWdCZ2dyQmdFRkJRY3dBWVlVYUhSMGNEb3ZMMjlqYzNBdVpHaG9jeTVuYjNZd1F3WUlLd1lCQlFVSE1BR0dOMmgwZEhBNkx5OW9hSE53YTJsdlkzTndMbTFoYm1GblpXUXVaVzUwY25WemRDNWpiMjB2VDBOVFVDOUlTRk5GYm5SeWRYTjBRMEV3SFFZRFZSMGxCQll3RkFZSUt3WUJCUVVIQXdFR0NDc0dBUVVGQndNQ01JSHRCZ05WSFI4RWdlVXdnZUl3UUtBK29EeUdPbWgwZEhBNkx5OW9hSE53YTJsamNtd3ViV0Z1WVdkbFpDNWxiblJ5ZFhOMExtTnZiUzlEVWt4ekwwaElVMFZ1ZEhKMWMzUkRRUzVqY213d2daMmdnWnFnZ1pla2daUXdnWkV4Q3pBSkJnTlZCQVlUQWxWVE1SZ3dGZ1lEVlFRS0V3OVZMbE11SUVkdmRtVnlibTFsYm5ReEREQUtCZ05WQkFzVEEwaElVekVpTUNBR0ExVUVDeE1aUTJWeWRHbG1hV05oZEdsdmJpQkJkWFJvYjNKcGRHbGxjekVrTUNJR0ExVUVBeE1iU0VoVExVWlFTMGt0U1c1MFpYSnRaV1JwWVhSbExVTkJMVVV4TVJBd0RnWURWUVFERXdkRFVrd3hOVGt5TUI4R0ExVWRJd1FZTUJhQUZFM1ZxaWFlRGtpKzVVWXMrT0VBZEFqNjlrTkVNQjBHQTFVZERnUVdCQlJRRElZLzZtb1lEZ05MVnJEQ2NjbzJiVURUbmpBTkJna3Foa2lHOXcwQkFRc0ZBQU9DQVFFQVgyNzZUSEJOUmx4RXY2cEswWFVaZ0pvcDNlV2o5cGVSR1VHMUFUUGtocWZUWjIydlNNQnRDVFhjcHJHV3NCQmxIVFZIc1ZkZ3F2VjVnbDhEUGtNOGt0bzNzR2FidmgxblZpNHBaUjFmelhKR3d1Nk5tVDhkaXM0TEJqMHJYN0oxOC9Rb29oN2pRSXBtaExDTm1KS0dyK2ROeDBOV3J0cEkvb1lVSFM1RXFkbHU2UmpZUHJPWlFTN0R6NCtFY1hkRC83WjU0RFN6dDQ3dlJ1ZDhkZklLTTBzS2txZCtqT2tjaTBoSUw3dGJnemN0NW1jclVVbVdQNmhmUWNNZGJQeXhmSlE3QWw2cmRjQ3g4WVBMcTRQV1RjSGJmSDJDOFJvOFZlVW5ldEt3ZXFqaHRmTkh1MWpmUGU1YXhvNi9YdU5BRDR3RVpUbndJbVo2blY5d0drVy9RZz09PC9kczpYNTA5Q2VydGlmaWNhdGU%2BPC9kczpYNTA5RGF0YT48L2RzOktleUluZm8%2BPC9kczpTaWduYXR1cmU%2BPHNhbWxwMjpTdGF0dXM%2BPHNhbWxwMjpTdGF0dXNDb2RlIFZhbHVlPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6c3RhdHVzOlN1Y2Nlc3MiLz48c2FtbHAyOlN0YXR1c01lc3NhZ2U%2BU3VjY2Vzczwvc2FtbHAyOlN0YXR1c01lc3NhZ2U%2BPC9zYW1scDI6U3RhdHVzPjxzYW1sMjpBc3NlcnRpb24gSUQ9IlNhbWxBc3NlcnRpb24tMTlhM2I5ZmI4NThkZjk3NGZiMTg4NGM5ZDIwYmFjNGYiIElzc3VlSW5zdGFudD0iMjAxNi0xMi0xN1QxMDo1NDo0NC4yNDBaIiBWZXJzaW9uPSIyLjAiIHhtbG5zOnNhbWwyPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXNzZXJ0aW9uIj48c2FtbDI6SXNzdWVyIEZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOm5hbWVpZC1mb3JtYXQ6ZW50aXR5Ij5hcHAxYS5pbXAuaGVhbHRoY2FyZS5nb3Y8L3NhbWwyOklzc3Vlcj48ZHM6U2lnbmF0dXJlIHhtbG5zOmRzPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjIj48ZHM6U2lnbmVkSW5mbz48ZHM6Q2Fub25pY2FsaXphdGlvbk1ldGhvZCBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvMTAveG1sLWV4Yy1jMTRuIyIvPjxkczpTaWduYXR1cmVNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjcnNhLXNoYTEiLz48ZHM6UmVmZXJlbmNlIFVSST0iI1NhbWxBc3NlcnRpb24tMTlhM2I5ZmI4NThkZjk3NGZiMTg4NGM5ZDIwYmFjNGYiPjxkczpUcmFuc2Zvcm1zPjxkczpUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjZW52ZWxvcGVkLXNpZ25hdHVyZSIvPjxkczpUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzEwL3htbC1leGMtYzE0biMiLz48L2RzOlRyYW5zZm9ybXM%2BPGRzOkRpZ2VzdE1ldGhvZCBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvMDkveG1sZHNpZyNzaGExIi8%2BPGRzOkRpZ2VzdFZhbHVlPnhWK1dsYWhhK2RYc0Rwd21ueTJ5VmE1L0dmbz08L2RzOkRpZ2VzdFZhbHVlPjwvZHM6UmVmZXJlbmNlPjwvZHM6U2lnbmVkSW5mbz48ZHM6U2lnbmF0dXJlVmFsdWU%2BWHJMUVZROWcxcTRuOXlaRFUrK29IZUovKy85aW1GUmcyOGd6UzV6c01QOEIwa3Q4cHovcm45ME8wUkZ1MlAyUkRaUXZ5eCtvL0NGTkZRYWVuVisrRG1sU0ppSW1IQlRpOXkrdENCUk9nZW1FYjRxd2RhNWtUK0MySVpsbzk2YkFPV09qTlZRY2Y1Y2RWNzBBaXpiNTVIam12UzkvU1RGdWtWSE9kbEtCOE1lWjMxWG0rMXh3cXdsbVJXbGxoZEpuNXo2bldBVlk3NmJJRnpXR29kK1NhTHJHd2UvVmNlSmFCQktCWEk3ejNBZmpDTkh3UHNrQ1BLOGRmUk1nWEx3Ti9Qa0RtRm8rV1Vla0ordEpLQ0VOZ1lxT0lXY3hnb0NYZkY4eVQzOHd1Y0JTRWRBU05wMzFXL2FEQ3ZZLzN6bTNaV0R0R1p1enVHQ0Y4cjl2MUZpSEhBPT08L2RzOlNpZ25hdHVyZVZhbHVlPjxLZXlJbmZvIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjIj48WDUwOURhdGE%2BPFg1MDlTdWJqZWN0TmFtZT5DTj1hcHAxYS5pbXAuaGVhbHRoY2FyZS5nb3YsT1U9RGV2aWNlcyxPVT1DTVMsT1U9SEhTLE89VS5TLiBHb3Zlcm5tZW50LEM9VVM8L1g1MDlTdWJqZWN0TmFtZT48WDUwOUNlcnRpZmljYXRlPk1JSUZ3VENDQkttZ0F3SUJBZ0lFVVVuZlV6QU5CZ2txaGtpRzl3MEJBUXNGQURCL01Rc3dDUVlEVlFRR0V3SlZVekVZTUJZR0ExVUVDaE1QVlM1VExpQkhiM1psY201dFpXNTBNUXd3Q2dZRFZRUUxFd05JU0ZNeElqQWdCZ05WQkFzVEdVTmxjblJwWm1sallYUnBiMjRnUVhWMGFHOXlhWFJwWlhNeEpEQWlCZ05WQkFNVEcwaElVeTFHVUV0SkxVbHVkR1Z5YldWa2FXRjBaUzFEUVMxRk1UQWVGdzB4TmpBMk1qQXhORE15TXpoYUZ3MHhPVEExTURreE5EQXlNekZhTUhneEN6QUpCZ05WQkFZVEFsVlRNUmd3RmdZRFZRUUtFdzlWTGxNdUlFZHZkbVZ5Ym0xbGJuUXhEREFLQmdOVkJBc1RBMGhJVXpFTU1Bb0dBMVVFQ3hNRFEwMVRNUkF3RGdZRFZRUUxFd2RFWlhacFkyVnpNU0V3SHdZRFZRUURFeGhoY0hBeFlTNXBiWEF1YUdWaGJIUm9ZMkZ5WlM1bmIzWXdnZ0VpTUEwR0NTcUdTSWIzRFFFQkFRVUFBNElCRHdBd2dnRUtBb0lCQVFEaU9FU1h2REMzTnUxVDIwSFV2S2FrRU1sUDVwTXJwVXp3VEtsSXU1UWxlUnV4dTlBRnNBSmpmei9wcmo3WGNqRUxxSTJmQmx4TGI0RXhqaFRNb20rWkJIRDFDa2diRXRoYkFUM0FmWHY2Tkh3MjNXMW13QUFIYmZORjNjNFVrMGJoWGRscXE0RmYyZ1MwZUcyNDA1ZjZkdnNGb3BXU3BXVUZIeHR3U1psaTBxcGNKRFlaSjZ5RWpyY0FaU2hPOFdRNEllT1pheVl3UE9udWFjODVYWktBZzVKcHhKWU5uR0c0QmQxRFFMWGJzM081cHYwd0l1bHcxVlNBb3ZnWXhuVWtHNW5KNXNUQmswVytqMHdoL1VKOTJJd1JTVUI4d0Y3WFJlblFEeDRDOTdBMCtSSzI3NHBTRjg0SmIxTXJEdXlhUVdXaUg0QXFDSXQ5SWhZeWliSGxBZ01CQUFHamdnSktNSUlDUmpBT0JnTlZIUThCQWY4RUJBTUNCYUF3RndZRFZSMGdCQkF3RGpBTUJncGdoa2dCWlFNQ0FRTUlNSUhMQmdnckJnRUZCUWNCQVFTQnZqQ0J1ekJTQmdnckJnRUZCUWN3QW9aR2FIUjBjRG92TDJob2MzQnJhV055YkM1dFlXNWhaMlZrTG1WdWRISjFjM1F1WTI5dEwwRkpRUzlEWlhKMGMwbHpjM1ZsWkZSdlNFaFRSVzUwY25WemRFTkJMbkEzWXpBZ0JnZ3JCZ0VGQlFjd0FZWVVhSFIwY0RvdkwyOWpjM0F1Wkdob2N5NW5iM1l3UXdZSUt3WUJCUVVITUFHR04yaDBkSEE2THk5b2FITndhMmx2WTNOd0xtMWhibUZuWldRdVpXNTBjblZ6ZEM1amIyMHZUME5UVUM5SVNGTkZiblJ5ZFhOMFEwRXdIUVlEVlIwbEJCWXdGQVlJS3dZQkJRVUhBd0VHQ0NzR0FRVUZCd01DTUlIdEJnTlZIUjhFZ2VVd2dlSXdRS0Erb0R5R09taDBkSEE2THk5b2FITndhMmxqY213dWJXRnVZV2RsWkM1bGJuUnlkWE4wTG1OdmJTOURVa3h6TDBoSVUwVnVkSEoxYzNSRFFTNWpjbXd3Z1oyZ2dacWdnWmVrZ1pRd2daRXhDekFKQmdOVkJBWVRBbFZUTVJnd0ZnWURWUVFLRXc5VkxsTXVJRWR2ZG1WeWJtMWxiblF4RERBS0JnTlZCQXNUQTBoSVV6RWlNQ0FHQTFVRUN4TVpRMlZ5ZEdsbWFXTmhkR2x2YmlCQmRYUm9iM0pwZEdsbGN6RWtNQ0lHQTFVRUF4TWJTRWhUTFVaUVMwa3RTVzUwWlhKdFpXUnBZWFJsTFVOQkxVVXhNUkF3RGdZRFZRUURFd2REVWt3eE5Ua3lNQjhHQTFVZEl3UVlNQmFBRkUzVnFpYWVEa2krNVVZcytPRUFkQWo2OWtORU1CMEdBMVVkRGdRV0JCUlFESVkvNm1vWURnTkxWckRDY2NvMmJVRFRuakFOQmdrcWhraUc5dzBCQVFzRkFBT0NBUUVBWDI3NlRIQk5SbHhFdjZwSzBYVVpnSm9wM2VXajlwZVJHVUcxQVRQa2hxZlRaMjJ2U01CdENUWGNwckdXc0JCbEhUVkhzVmRncXZWNWdsOERQa004a3RvM3NHYWJ2aDFuVmk0cFpSMWZ6WEpHd3U2Tm1UOGRpczRMQmowclg3SjE4L1Fvb2g3alFJcG1oTENObUpLR3IrZE54ME5XcnRwSS9vWVVIUzVFcWRsdTZSallQck9aUVM3RHo0K0VjWGRELzdaNTREU3p0NDd2UnVkOGRmSUtNMHNLa3FkK2pPa2NpMGhJTDd0Ymd6Y3Q1bWNyVVVtV1A2aGZRY01kYlB5eGZKUTdBbDZyZGNDeDhZUExxNFBXVGNIYmZIMkM4Um84VmVVbmV0S3dlcWpodGZOSHUxamZQZTVheG82L1h1TkFENHdFWlRud0ltWjZuVjl3R2tXL1FnPT08L1g1MDlDZXJ0aWZpY2F0ZT48L1g1MDlEYXRhPjwvS2V5SW5mbz48L2RzOlNpZ25hdHVyZT48c2FtbDI6U3ViamVjdD48c2FtbDI6TmFtZUlEIEZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6MS4xOm5hbWVpZC1mb3JtYXQ6dW5zcGVjaWZpZWQiIE5hbWVRdWFsaWZpZXI9IiI%2BZmZtPC9zYW1sMjpOYW1lSUQ%2BPHNhbWwyOlN1YmplY3RDb25maXJtYXRpb24gTWV0aG9kPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6Y206YmVhcmVyIj48c2FtbDI6U3ViamVjdENvbmZpcm1hdGlvbkRhdGEgTm90T25PckFmdGVyPSIyMDE2LTEyLTE3VDEwOjU5OjQ0LjI0MFoiIFJlY2lwaWVudD0iaHR0cDovL2dldGhlYWx0aC5zb2Z0b2Jpei5pbmZvL0FwcGxpY2F0aW9uRm9ybS9Ub2JhY29vVXNlciIvPjwvc2FtbDI6U3ViamVjdENvbmZpcm1hdGlvbj48L3NhbWwyOlN1YmplY3Q%2BPHNhbWwyOkNvbmRpdGlvbnMgTm90QmVmb3JlPSIyMDE2LTEyLTE3VDEwOjUyOjQ0LjI0MFoiIE5vdE9uT3JBZnRlcj0iMjAxNi0xMi0xN1QxMDo1OTo0NC4yNDBaIj48c2FtbDI6QXVkaWVuY2VSZXN0cmljdGlvbj48c2FtbDI6QXVkaWVuY2U%2BMDQuS0dMLkxBKi4yMjUuOTUwPC9zYW1sMjpBdWRpZW5jZT48L3NhbWwyOkF1ZGllbmNlUmVzdHJpY3Rpb24%2BPC9zYW1sMjpDb25kaXRpb25zPjxzYW1sMjpBdHRyaWJ1dGVTdGF0ZW1lbnQ%2BPHNhbWwyOkF0dHJpYnV0ZSBOYW1lPSJJbmZvcm1hdGlvbiBFeGNoYW5nZSBTeXN0ZW0gSUQiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6dW5zcGVjaWZpZWQiPjxzYW1sMjpBdHRyaWJ1dGVWYWx1ZT4wNC5LR0wuTEEqLjIyNS45NTA8L3NhbWwyOkF0dHJpYnV0ZVZhbHVlPjwvc2FtbDI6QXR0cmlidXRlPjxzYW1sMjpBdHRyaWJ1dGUgTmFtZT0iU3RhdGUgRXhjaGFuZ2UgQ29kZSIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDp1bnNwZWNpZmllZCI%2BPHNhbWwyOkF0dHJpYnV0ZVZhbHVlPkZMMDwvc2FtbDI6QXR0cmlidXRlVmFsdWU%2BPC9zYW1sMjpBdHRyaWJ1dGU%2BPHNhbWwyOkF0dHJpYnV0ZSBOYW1lPSJQYXJ0bmVyIEFzc2lnbmVkIENvbnN1bWVyIElEIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVuc3BlY2lmaWVkIj48c2FtbDI6QXR0cmlidXRlVmFsdWU%2BNTg8L3NhbWwyOkF0dHJpYnV0ZVZhbHVlPjwvc2FtbDI6QXR0cmlidXRlPjxzYW1sMjpBdHRyaWJ1dGUgTmFtZT0iRkZFIEFzc2lnbmVkIENvbnN1bWVyIElEIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVuc3BlY2lmaWVkIj48c2FtbDI6QXR0cmlidXRlVmFsdWU%2BMTM4NTE1NjI2PC9zYW1sMjpBdHRyaWJ1dGVWYWx1ZT48L3NhbWwyOkF0dHJpYnV0ZT48c2FtbDI6QXR0cmlidXRlIE5hbWU9IlVzZXIgVHlwZSIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDp1bnNwZWNpZmllZCI%2BPHNhbWwyOkF0dHJpYnV0ZVZhbHVlPkNvbnN1bWVyPC9zYW1sMjpBdHRyaWJ1dGVWYWx1ZT48L3NhbWwyOkF0dHJpYnV0ZT48c2FtbDI6QXR0cmlidXRlIE5hbWU9IkZGRSBVc2VyIElEIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVuc3BlY2lmaWVkIj48c2FtbDI6QXR0cmlidXRlVmFsdWUvPjwvc2FtbDI6QXR0cmlidXRlPjxzYW1sMjpBdHRyaWJ1dGUgTmFtZT0iVHJhbnNmZXIgVHlwZSIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDp1bnNwZWNpZmllZCI%2BPHNhbWwyOkF0dHJpYnV0ZVZhbHVlPkNvbXBsZXRlZCBlbGlnaWJpbGl0eSBhcHBsaWNhdGlvbjwvc2FtbDI6QXR0cmlidXRlVmFsdWU%2BPC9zYW1sMjpBdHRyaWJ1dGU%2BPHNhbWwyOkF0dHJpYnV0ZSBOYW1lPSJFeGNlcHRpb24gUmVhc29uIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OnVuc3BlY2lmaWVkIj48c2FtbDI6QXR0cmlidXRlVmFsdWUvPjwvc2FtbDI6QXR0cmlidXRlPjwvc2FtbDI6QXR0cmlidXRlU3RhdGVtZW50PjxzYW1sMjpBdXRoblN0YXRlbWVudCBBdXRobkluc3RhbnQ9IjIwMTYtMTItMTdUMTA6NTQ6NDQuMjQwWiI%2BPHNhbWwyOlN1YmplY3RMb2NhbGl0eSBBZGRyZXNzPSIxMC4xNTMuMTk3LjUxIi8%2BPHNhbWwyOkF1dGhuQ29udGV4dD48c2FtbDI6QXV0aG5Db250ZXh0Q2xhc3NSZWY%2BdXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFjOmNsYXNzZXM6UGFzc3dvcmQ8L3NhbWwyOkF1dGhuQ29udGV4dENsYXNzUmVmPjwvc2FtbDI6QXV0aG5Db250ZXh0Pjwvc2FtbDI6QXV0aG5TdGF0ZW1lbnQ%2BPC9zYW1sMjpBc3NlcnRpb24%2BPC9zYW1scDI6UmVzcG9uc2U%2B";
            string saml = payload.Replace("SAMLResponse=", "");
            saml = WebUtility.UrlDecode(saml);
            string xmlOriginal = DecodeStringFromBase64(saml);
            string xml = AttributeToElement(xmlOriginal);
            XmlDocument xDoc = new XmlDocument();
            xmlOriginal = xmlOriginal.Replace(@"\", "");
            xDoc.LoadXml(xmlOriginal);

            var stringReader = new System.IO.StringReader(xml);
            var serializer = new XmlSerializer(typeof(Response));
            Response result = (Response)serializer.Deserialize(stringReader);

            XmlDocument doc2 = xDoc;
            XmlNamespaceManager xMan = new XmlNamespaceManager(xDoc.NameTable);
            xMan.AddNamespace("samlp", "urn:oasis:names:tc:SAML:2.0:protocol");
            xMan.AddNamespace("saml", "urn:oasis:names:tc:SAML:2.0:assertion");
            xMan.AddNamespace("ds", "http://www.w3.org/2000/09/xmldsig#");

            #region Deserialize
            XmlNode xNode = xDoc.SelectSingleNode("/samlp:Response/samlp:Status/samlp:StatusCode/@Value", xMan);


            #region Older

            if (xNode != null)
            {
                resOld.AuthenticationStatus = false;
                string statusCode = xNode.Value;
                if (statusCode.EndsWith("status:Success"))
                {
                    resOld.AuthenticationStatus = true;
                }

            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/@Destination", xMan);
            if (xNode != null)
            {
                resOld.Destination = xNode.Value;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/@IssueInstant", xMan);
            if (xNode != null)
            {
                resOld.AutheticationTime = Convert.ToDateTime(xNode.Value);
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/@ID", xMan);
            if (xNode != null)
            {
                resOld.ResponseID = xNode.Value;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Issuer", xMan);
            if (xNode != null)
            {
                resOld.Issuer = xNode.InnerText;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestValue", xMan);
            if (xNode != null)
            {
                resOld.SignatureReferenceDigestValue = xNode.InnerText;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/ds:Signature/ds:SignatureValue", xMan);
            if (xNode != null)
            {
                resOld.SignatureValue = xNode.InnerText;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/@ID", xMan);
            if (xNode != null)
            {
                resOld.AuthenticationSession = xNode.Value;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:Subject/saml:NameID", xMan);
            if (xNode != null)
            {
                resOld.SubjectNameID = xNode.InnerText;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:Conditions/saml:AudienceRestriction/saml:Audience", xMan);
            if (xNode != null)
            {
                resOld.Audience = xNode.InnerText;
            }

            //reverse order
            //</saml:AttributeValue></saml:Attribute></saml:AttributeStatement></saml:Assertion></samlp:Response>

            //string xQryStr = "//NewPatient[Name='" + name + "']";

            //XmlNode matchedNode = xDoc.SelectSingleNode(xQryStr);
            // samlp:Response  saml:Assertion saml:AttributeStatement saml:Attribute
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Information Exchange System ID']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.InformationExchangeSystemID = xNode.InnerText;
            }

            // samlp:Response  saml:Assertion saml:AttributeStatement saml:Attribute
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'State Exchange Code']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.StateExchangeCode = xNode.InnerText;
            }

            // samlp:Response  saml:Assertion saml:AttributeStatement saml:Attribute
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Partner Assigned Consumer ID']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.PartnerAssignedConsumerID = xNode.InnerText;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'FFE Assigned Consumer ID']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.FFEAssignedConsumerID = xNode.InnerText;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'User Type']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.UserType = xNode.InnerText;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'FFE User ID']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.FFEUserID = xNode.InnerText;
            }
            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Transfer Type']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.TransferType = xNode.InnerText;
            }

            xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Exception Reason']/saml:AttributeValue", xMan);
            if (xNode != null)
            {
                resOld.ExceptionReason = xNode.InnerText;
            }

            #endregion

            if (result.Status.StatusCode.Value.EndsWith("status:Success"))
                res.AuthenticationStatus = true;

            res.Destination = result.Destination;
            res.AutheticationTime = Convert.ToDateTime(result.Assertion.IssueInstant);


            //xNode = xDoc.SelectSingleNode("/samlp:Response/@ID", xMan);
            res.ResponseID = result.ID;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Issuer", xMan);
            res.Issuer = result.Issuer.Text;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestValue", xMan);
            res.SignatureReferenceDigestValue = result.Signature.SignedInfo.Reference.DigestValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/ds:Signature/ds:SignatureValue", xMan);
            res.SignatureValue = result.Signature.SignatureValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/@ID", xMan);
            res.AuthenticationSession = result.Assertion.ID;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:Subject/saml:NameID", xMan);
            res.SubjectNameID = result.Assertion.Subject.NameID.Text;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:Conditions/saml:AudienceRestriction/saml:Audience", xMan);
            res.Audience = result.Assertion.Conditions.AudienceRestriction.Audience;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Information Exchange System ID']/saml:AttributeValue", xMan);
            res.InformationExchangeSystemID = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "INFORMATION EXCHANGE SYSTEM ID").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'State Exchange Code']/saml:AttributeValue", xMan);
            res.StateExchangeCode = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "STATE EXCHANGE CODE").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Partner Assigned Consumer ID']/saml:AttributeValue", xMan);
            res.PartnerAssignedConsumerID = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "PARTNER ASSIGNED CONSUMER ID").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'FFE Assigned Consumer ID']/saml:AttributeValue", xMan);
            res.FFEAssignedConsumerID = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "FFE ASSIGNED CONSUMER ID").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'User Type']/saml:AttributeValue", xMan);
            res.UserType = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "USER TYPE").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'FFE User ID']/saml:AttributeValue", xMan);
            res.FFEUserID = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "FFE USER ID").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Transfer Type']/saml:AttributeValue", xMan);
            res.TransferType = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "TRANSFER TYPE").FirstOrDefault().AttributeValue;

            //xNode = xDoc.SelectSingleNode("/samlp:Response/saml:Assertion/saml:AttributeStatement/saml:Attribute[@Name = 'Exception Reason']/saml:AttributeValue", xMan);
            res.ExceptionReason = result.Assertion.AttributeStatement.Attribute.Where(x => x.Name.ToUpper() == "EXCEPTION REASON").FirstOrDefault().AttributeValue;
            #endregion

        

            var oType = resOld.GetType();

            foreach (var oProperty in oType.GetProperties())
            {
                var oOldValue = oProperty.GetValue(resOld, null);
                var oNewValue = oProperty.GetValue(res, null);
                // this will handle the scenario where either value is null
                if (!object.Equals(oOldValue, oNewValue))
                {
                    // Handle the display values when the underlying value is null
                    var sOldValue = oOldValue == null ? "null" : oOldValue.ToString();
                    var sNewValue = oNewValue == null ? "null" : oNewValue.ToString();

                    Console.WriteLine("Property " + oProperty.Name + " was: " + sOldValue + "; is: " + sNewValue);
                }
            }
            Console.ReadLine();
        }

        private static string DecodeStringFromBase64(string stringToDecode)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(stringToDecode));
        }

        private static string Beautify(XmlDocument doc)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }
            return sb.ToString();
        }

        private static string RemoveAllNamespaces(string xmlDocument)
        {
            XElement xmlDocumentWithoutNs = RemoveAllNamespaces(XElement.Parse(xmlDocument));

            return xmlDocumentWithoutNs.ToString();
        }

        //Core recursion function
        private static XElement RemoveAllNamespaces(XElement xmlDocument)
        {
            if (!xmlDocument.HasElements)
            {
                XElement xElement = new XElement(xmlDocument.Name.LocalName);
                xElement.Value = xmlDocument.Value;

                foreach (XAttribute attribute in xmlDocument.Attributes())
                {
                    xElement.Add(attribute);
                }

                return xElement;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }

        private static string AttributeToElement(string xmlString)
        {
            XElement xm = XElement.Parse(xmlString);
            Recursive(xm);
            XElement xmm = RemoveAllNamespaces(xm);
            return xmm.ToString();
        }

        private static void Recursive(XElement element)
        {
            if (element.HasElements)
            {
                foreach (XAttribute att in element.Attributes())
                {
                    element.AddFirst(new XElement(att.Name.LocalName, att.Value));
                }
                element.Attributes().Remove();
                foreach (XElement item in element.Elements())
                {
                    if (item.HasAttributes)
                    {
                        if (!item.HasElements)
                            item.AddFirst(new XElement("Text", item.Value));

                        foreach (XAttribute att in item.Attributes())
                        {
                            item.AddFirst(new XElement(att.Name.LocalName, att.Value));
                        }
                        item.Attributes().Remove();

                    }
                    if (item.HasElements)
                    {
                        Recursive(item);
                    }
                }
            }
            else
            {
                if (element.HasAttributes)
                {
                    element.AddFirst(new XElement("Text", element.Value));
                    foreach (XAttribute att in element.Attributes())
                    {
                        element.AddFirst(new XElement(att.Name.LocalName, att.Value));
                    }
                }
            }

        }

    }

    public class SAMLResponse
    {
        #region Properties
        public string DecodedSAML { get; set; }
        public string EncodedeSAML { get; set; }
        public string Audience { get; set; }
        public string SubjectNameID { get; set; }
        public string InformationExchangeSystemID { get; set; }
        public string StateExchangeCode { get; set; }
        public string PartnerAssignedConsumerID { get; set; }
        public string FFEAssignedConsumerID { get; set; }
        public string UserType { get; set; }
        public string FFEUserID { get; set; }
        public string TransferType { get; set; }
        public string ExceptionReason { get; set; }
        public bool AuthenticationStatus { get; set; }
        public string Issuer { get; set; }
        public string Destination { get; set; }
        public string ResponseID { get; set; }
        public bool VerifiedResponse { get; set; }
        public string SignatureValue { get; set; }
        public string SignatureReferenceDigestValue { get; set; }
        public DateTime AutheticationTime { get; set; }
        public string AuthenticationSession { get; set; }
        #endregion
    }


}
