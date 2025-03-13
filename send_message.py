import boto3

# Initialize a Boto3 client for SQS
sqs_client = boto3.client('sqs', region_name='eu-north-1')  

queue_url = 'https://sqs.eu-north-1.amazonaws.com/147997134556/MKQueue'

try:
    # Send a message to the SQS queue
    response = sqs_client.send_message(
        QueueUrl=queue_url,
      # My message 
        MessageBody='Hello from Python!' 
    )
    print(f"Message sent! Message ID: {response['MessageId']}")
except Exception as e:
    print(f"Error sending message: {str(e)}")
