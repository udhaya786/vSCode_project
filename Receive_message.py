import boto3

# Initialize a Boto3 client for SQS
sqs_client = boto3.client('sqs', region_name='eu-north-1')  

queue_url = 'https://sqs.eu-north-1.amazonaws.com/147997134556/MKQueue'

try:
    # Receive a message from the SQS queue
    response = sqs_client.receive_message(
        QueueUrl=queue_url,
     WaitTimeSeconds=10,
      
    )
    print(f"Message received! Message ID: {response.get('Messages',[])}")
except Exception as e:
    print(f"Error receive message: {str(e)}")
