# Packettor
A network visualization and analysis tool for Windows. 


Tool creates or uses c:\networklogs. 
Creates a csv file with content similar to below: 


UDPRecv,192.168.2.82,5353,224.0.0.251,5353,nvcontainer,11/13/2022 9:55:56 AM,146
UDPRecv,192.168.2.82,5353,224.0.0.251,5353,svchost,11/13/2022 9:55:56 AM,146
UDPRecv,192.168.2.82,5353,224.0.0.251,5353,msedge,11/13/2022 9:55:56 AM,146
UDPRecv,192.168.2.82,5353,224.0.0.251,5353,chrome,11/13/2022 9:55:56 AM,146
TCPSend,192.168.2.45,62015,20.192.44.69,443,PhoneExperienceHost,11/13/2022 9:55:56 AM,31
...

Format is: 

type, src ip, src port, dst ip, dst port, process, timestamp, size of packet


It will keep logging this information until the log file hits a GB of size and then it will overwrite events. The service keeps an audit trail of packets exchanged for the past 1GB of events which should be many. Currently doesn't capture payload data but may be added in the future. 


Install with installutil..
